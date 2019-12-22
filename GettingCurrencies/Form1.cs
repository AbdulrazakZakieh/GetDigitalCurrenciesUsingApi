using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GettingCurrencies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            digitalCurrenciesDataGridView.ColumnCount = 3;
            digitalCurrenciesDataGridView.Columns[0].HeaderText = "Rank";
            digitalCurrenciesDataGridView.Columns[1].HeaderText = "Name";
            digitalCurrenciesDataGridView.Columns[2].HeaderText = "Price in $";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            string response = httpClient.GetStringAsync("https://api.coinmarketcap.com/v1/ticker/").Result;

            dynamic currencies = JsonConvert.DeserializeObject<dynamic>(response);

            digitalCurrenciesDataGridView.RowCount = currencies.Count;

            for (int i = 0; i < currencies.Count; i++)
            {
                digitalCurrenciesDataGridView.Rows[i].Cells[0].Value = currencies[i].rank;
                digitalCurrenciesDataGridView.Rows[i].Cells[1].Value = currencies[i].name;
                digitalCurrenciesDataGridView.Rows[i].Cells[2].Value = currencies[i].price_usd;
            }
        }
    }
}

