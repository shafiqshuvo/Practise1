using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
   
       public class Account
       {
            //private string accountNumber;
            //private string customerName;

            private double balance;

            public string AccountNumber { set; get; }
            public string CustomerName { set; get; }

            public void Deposit(double amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                }
                else
                {
                    MessageBox.Show("Positive amount");
                }

            }
            public void Withdraw(double amount)
            {
                if (balance >= amount)
                {
                    balance -= amount;
                }
                else
                {
                    MessageBox.Show(@"No sufficient balance");
                }

            }

            public string GetReport()
            {
                string message = CustomerName + ", your account no: " + AccountNumber + " and its balance:" + balance + " taka";
                return message;
            }
       }
    }
