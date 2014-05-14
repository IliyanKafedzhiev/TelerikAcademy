using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{
    public class LoanAcc : BankAccount
    {
        public override void  Deposit(decimal sum)
        {
            this.Balance = this.Balance + sum;
        }
        public override decimal InterestAmountForPereiod(int mounts)
        {
            int gratirs = 0;
            if (this.Customer is Individual)
            {
                if (mounts < 3)
                {
                    throw new ArgumentException("You must define min 3 mounts");
                }
                gratirs = 3;
            }
            else if (this.Customer is Companie)
            {
                if (mounts < 2)
                {
                    throw new ArgumentException("You must define min 2 mounts");
                }
                gratirs = 2;
            }
            else
            {
                throw new TypeUnloadedException("unknown customer type");
            }
            mounts = mounts - gratirs;
            return mounts * InterestRate;
        }

        public LoanAcc(decimal balance, Customer client, decimal interest):base(balance,client,interest)
        {
        }
    }
}
