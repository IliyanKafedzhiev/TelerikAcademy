using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{
    public class DepositAcc : BankAccount
    {
        public override void Deposit(decimal sum)
        {
            this.Balance = this.Balance + sum;
        }

        public override void WithDraw(decimal sum)
        {
            if (sum < this.Balance)
            {
                this.Balance = this.Balance - sum;
            }
            else
            {
                throw new ArgumentException("It's impossible to withrow sum lesser than your ballance!");
            }
            
        }

        public override decimal InterestAmountForPereiod(int mounts)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            return mounts * InterestRate;
        }

        public DepositAcc(decimal balance, Customer client, decimal interest):base(balance,client,interest)
        {
        }
    }
}
