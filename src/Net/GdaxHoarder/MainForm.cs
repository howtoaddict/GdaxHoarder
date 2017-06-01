using CoinbaseExchange.NET.Core;
using CoinbaseExchange.NET.Endpoints.Account;
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

        private void btnBankDeposit_Click(object sender, EventArgs e)
        {

        }
    }
}
