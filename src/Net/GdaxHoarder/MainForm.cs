using CoinbaseExchange.NET.Core;
using CoinbaseExchange.NET.Endpoints;
using CoinbaseExchange.NET.Endpoints.Account;
using CoinbaseExchange.NET.Endpoints.Deposits;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var settings = GdaxSettings.Parse("../../../../.keys");
            ExchangeClientBase.IsSandbox = settings.IsSandbox;

            _api = new GdaxApi(settings.ToAuthContainer());
        }

        private GdaxApi _api;
        private async void btnMain_Click(object sender, EventArgs e)
        {
            var status = await _api.Account.ListAccounts();

            var x = status.ToString();
        }

        private void btnBuyLtc_Click(object sender, EventArgs e)
        {
            
        }

        private async void btnBankDeposit_Click(object sender, EventArgs e)
        {
            var methods = await _api.PaymentMethods.GetPaymentMethodsAsync();

            var ach = methods.Items.FirstOrDefault(a => a.Type == "ach_bank_account");
            if (ach == null)
            {
                MessageBox.Show("Please define ACH Bank Deposit in your account before proceeding");
                return;
            }

            var result = await _api.Deposits.PaymentMethod(
                numDeposit.Value,
                "USD",
                ach.Id);

            var displayString = "Error: " + result.HttpResponse.ContentBody;
            if (result.HttpResponse.IsSuccessStatusCode)
                displayString = "Deposit successfuly posted, payout at: " + result.PayoutAt;

            MessageBox.Show(displayString);
        }
    }
}
