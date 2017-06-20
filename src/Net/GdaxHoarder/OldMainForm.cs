using CoinbaseExchange.NET.Core;
using CoinbaseExchange.NET.CoreGenerics;
using CoinbaseExchange.NET.Endpoints;
using CoinbaseExchange.NET.Endpoints.Account;
using CoinbaseExchange.NET.Endpoints.Deposits;
using CoinbaseExchange.NET.Endpoints.Orders;
using CoinbaseExchange.NET.Endpoints.PaymentMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GdaxHoarder
{
    public partial class OldMainForm : Form
    {
        public OldMainForm()
        {
            InitializeComponent();

            var settings = GdaxSettings.Parse(AppConsts.KEYS_PATH);
            ExchangeClientBase.IsSandbox = settings.IsSandbox;

            _api = new GdaxApi(settings.ToAuthContainer());
        }

        private GdaxApi _api;
        private async void btnMain_Click(object sender, EventArgs e)
        {
            var status = await _api.Account.ListAccounts();

            var sb = new StringBuilder();
            foreach (var item in status.Accounts)
            {
                sb.AppendFormat("{0} - {1}", item.Currency, item.Available);
                sb.AppendLine();
            }

            MessageBox.Show(sb.ToString(), "Balances");
        }

        private async void btnBankDeposit_Click(object sender, EventArgs e)
        {
            preRequest(btnBankDeposit);
            var methods = await _api.PaymentMethods.GetPaymentMethodsAsync();

            var ach = methods.Items.FirstOrDefault(a => a.Type == "ach_bank_account");
            if (ach == null)
            {
                MessageBox.Show("Please define ACH Bank Deposit in your account before proceeding");
                return;
            }

            var resp = await _api.Deposits.PaymentMethod(numDeposit.Value, "USD", ach.Id);
            if (httpSuccess(resp, btnBankDeposit))
            {
                var str = String.Format("Deposit successfuly posted! {0} {1} will be in account by {2}",
                    resp.Amount.ToString("N0"), resp.Currency, resp.PayoutAt);
                MessageBox.Show(str, "Deposit Posted");
            }
        }

        private void btnBuyBtc_Click(object sender, EventArgs e)
        {
            processMarketOrder(btnBtc, "BTC-USD", numBtc.Value);
        }

        private void btnBuyEth_Click(object sender, EventArgs e)
        {
            processMarketOrder(btnEth, "ETH-USD", numEth.Value);
        }

        private void btnBuyLtc_Click(object sender, EventArgs e)
        {
            processMarketOrder(btnLtc, "LTC-USD", numLtc.Value);
        }

        private void preRequest(Button btn)
        {
            btn.Enabled = false;
        }

        private async void processMarketOrder(Button btn, string productId, decimal funds)
        {
            preRequest(btn);
            var req = new OrdersMarketRequest
            {
                Side = "buy",
                ProductId = productId,
                Funds = funds.ToString()
            };

            var resp = await _api.Orders.PostOrderMarket(req);
            if (httpSuccess(resp, btn))
            {
                var str = String.Format("Order {0} placed at {1}. Settled: {2}",
                    resp.Id, resp.CreatedAt, resp.Settled);
                MessageBox.Show(str, productId +" Order Placed");
            }
        }

        private bool httpSuccess(ExchangeResponseGenericBase resp, Button btn)
        {
            var httpResp = resp.HttpResponse;
            if (!httpResp.IsSuccessStatusCode)
            {
                MessageBox.Show(
                    httpResp.ContentBody,
                    "Error - "+ httpResp.StatusCode);
            }

            btn.Enabled = true;
            return httpResp.IsSuccessStatusCode;
        }
    }
}
