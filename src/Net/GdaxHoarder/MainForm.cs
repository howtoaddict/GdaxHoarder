using CoinbaseExchange.NET.Core;
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
        private GdaxSettings _settings;
        public MainForm()
        {
            InitializeComponent();

            _settings = GdaxSettings.Parse("../../../../.keys");
            ExchangeClientBase.IsSandbox = _settings.IsSandbox;
        }

        private async void btnMain_Click(object sender, EventArgs e)
        {
            var api = new AccountClient(_settings.ToAuthContainer());

            var status = await api.ListAccounts();

            var x = status.ToString();
        }

        private void btnBuyLtc_Click(object sender, EventArgs e)
        {
            
        }

        private async void btnBankDeposit_Click(object sender, EventArgs e)
        {
            var clientPaymentMethods = new PaymentMethodsClient(_settings.ToAuthContainer());
            var methods = await clientPaymentMethods.GetPaymentMethodsAsync();

            var ach = methods.PaymentMethods.FirstOrDefault(a => a.Type == "ach_bank_account");
            if (ach == null)
            {
                MessageBox.Show("Please define ACH Bank Deposit in your account before proceeding");
                return;
            }

            var deposit = new DepositsClient(_settings.ToAuthContainer());
            var result = await deposit.PostDepositsPaymentMethodAsync(
                numDeposit.Value,
                "USD",
                ach.Id);

            var displayString = "Error: " + result.HttpResponse.ContentBody;
            if (result.HttpResponse.IsSuccessStatusCode)
                displayString = "Deposit successfuly posted, payout at: " + result.Result.PayoutAt;

            MessageBox.Show(displayString);
        }
    }
}
