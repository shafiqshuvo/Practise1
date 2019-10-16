using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        public AccountOperationUi()
        {
            InitializeComponent();
        }

        Account account = new Account();

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if( !String.IsNullOrEmpty(accountNoTextBox.Text) && !String.IsNullOrEmpty(customerNameTextBox.Text))
            {
                account.AccountNumber = accountNoTextBox.Text;
                account.CustomerName = customerNameTextBox.Text;

                accountNoTextBox.Clear();
                customerNameTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Feild Can't be empty!!!");
            }
            
        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(amountTextBox.Text))
            {
                double amount = Convert.ToDouble(amountTextBox.Text);
                account.Deposit(amount);
                amountTextBox.Clear();

            }

            else
            {
                MessageBox.Show("Feild Can't be empty!!!");
            }



        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(amountTextBox.Text))
            {
                double amount = Convert.ToDouble(amountTextBox.Text);
                account.Withdraw(amount);

                amountTextBox.Clear();
            }

            else
            {
                MessageBox.Show("Feild Can't be empty!!!");
            }

        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(account.GetReport());
        }
    }
}
