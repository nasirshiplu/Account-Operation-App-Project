using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcountOperationApp
{
    public partial class accountOperationUI : Form
    {
        public accountOperationUI()
        {
            InitializeComponent();
        }
        Account account =new Account();
        private void accountCreateButton_Click(object sender, EventArgs e)
        {
            
            if (accountNumberTextBox.Text == "" || customerNameTextBox.Text=="")
            {
                MessageBox.Show("Don't Submit Null Value");
            }
            else
            {
                account.accountId = accountNumberTextBox.Text;
                account.customerName = customerNameTextBox.Text;
                MessageBox.Show("Account Created");
                accountNumberTextBox.Clear();
                customerNameTextBox.Clear(); 
            }
            
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(amountTextBox.Text);
            if (amount<0)
            {
                MessageBox.Show("Don't Use Negetive Value");
            }
            else
            {
                account.DepositBalance(amount);
                MessageBox.Show("Your Balance is " + account.balance);
                amountTextBox.Clear();
            }
            
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(amountTextBox.Text);
            if (amount < 0)
            {
                MessageBox.Show("Don't Use Negetive Value");
            }
            else if (account.balance<amount)
            {
                MessageBox.Show("Insufficient Balance");
            }
            else
            {
                account.WithdrawBalance(amount);
                MessageBox.Show("Total Balance after Withdraw " + account.balance);
                amountTextBox.Clear();
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(account.customerName + " , your account number: " + account.accountId +
                            " and it's balance: " + account.balance + " taka.");
        }
    }
}
