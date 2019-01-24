using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zaemdll;

namespace ProjectZaem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ResultBtn_Click(object sender, EventArgs e)
        {

            /* ******************* */

            //double gosho = 1.0; // 1.0
            //double pesho = 2.0; // 2.0
            //double resultPeshoGosho = gosho + pesho; // 3.0

            //string goshoString = gosho.ToString(); // '1.0'
            //string peshoString = pesho.ToString(); // '2.0'
            //string resultPeshoGoshoString = goshoString + peshoString; // '1.02.0'

            /* ******************* */

            /* ******************* */
            // int integer = 5; // 5
            // double number = 5.0d; // 5.0
            //  string text = "gosho";
            //  float number2 = 5.1f; // 5.1
            // decimal number3 = 5.0m; // 5.0
            // char OneLetter = 'b';

            /* ******************* */

            //double interest = Double.Parse(YearInterestTxt.Text) / 100;
            //double month = Double.Parse(CreditDeadlineTxt.Text) / 12;
            //double result = Double.Parse(CreditAmountTxt.Text) * (1 + (interest * month));
            //string resultString = result.ToString();

            //MonthlyResult.Text = resultString;

            var results = Zaem.Calculate(decimal.Parse(CreditAmountTxt.Text), decimal.Parse(CreditDeadlineTxt.Text), decimal.Parse(YearInterestTxt.Text));
            //Zaem zaem = new Zaem(CreditAmountTxt.Text, CreditDeadlineTxt.Text, YearInterestTxt.Text);

            TotalResult.Text = results.TotalResult.ToString();
            MonthlyResult.Text = results.MonthlyResult.ToString();
        }

        private void YearInterestTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
