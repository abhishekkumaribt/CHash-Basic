using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    public class Account
    {
        public long accountNo;
        public double balance;
        public string[] payees;
        public long[] payeesAccount;
        public Account()
        {

        }
        public Account(long accountNo,double balance)
        {
            this.accountNo = accountNo;
            this.balance = balance;
        }
        public Account(long accountNo,double balance,string[] payees,long[]payeesAccount):this(accountNo,balance)
        {
            this.payees = payees;
            this.payeesAccount = payeesAccount;
        }
        public int DebitAmount(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return 1;
            }
            return 0;
        }
        public int TransferMoney(long payeeAccountNo,double amount)
        {
            if(Array.IndexOf(payeesAccount,accountNo)>=0)
            {
                return DebitAmount(amount);
            }
            return -1;
        }
        public int TransferMoney(string nickname,double amount)
        {
            if (Array.IndexOf(payees, nickname) >= 0)
            {
                return DebitAmount(amount);
            }
            return -1;
        }
    }
}
