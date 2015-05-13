using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcountOperationApp
{
    class Account
    {
        public string accountId;
        public string customerName;
        public decimal balance;

        public decimal DepositBalance(decimal amount)
        {
            //if (amount<0)
            //{
            //    return amount;
            //}
            //else
            //{
            //    balance += amount;
            //    return balance;
            //}
            balance += amount;
            return balance;
        }

        public decimal WithdrawBalance(decimal amount)
        {
            decimal balanceAfterWithdraw = balance - amount;
            if (balanceAfterWithdraw>=0)
            {
                balance = balanceAfterWithdraw;
                return balance;
            }
            else
            {
                return amount;
            }
        }
    }
   
}
