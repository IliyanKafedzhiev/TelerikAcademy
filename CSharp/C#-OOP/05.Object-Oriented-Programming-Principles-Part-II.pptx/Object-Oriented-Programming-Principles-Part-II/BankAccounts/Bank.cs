using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{
    public class Bank
    {
        private List<BankAccount> accounts;

        public Bank(BankAccount[] accounts)
        {
            this.accounts = new List<BankAccount>();
            foreach (BankAccount item in accounts)
            {
                this.accounts.Add(item);
            }
        }

        public void addAccount (BankAccount account)
        {
            this.accounts.Add(account);
        }
    }
}
