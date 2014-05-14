using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{
    public class MortgageAcc : BankAccount
    {
        public override void Deposit(decimal sum)
        {
            this.Balance = this.Balance + sum;
        }
        public override decimal InterestAmountForPereiod(int mounts)
        {
            if (this.Customer is Companie)
            {
                decimal premiumInterest = this.InterestRate / 2;
                if (mounts < 13)
                {
                    return mounts * premiumInterest;
                }
                else
                {
                    return (12 * premiumInterest) + ((mounts - 12) * this.InterestRate);
                }                     
            }
            else if (this.Customer is Individual)
            {
                if (mounts < 7)
                {
                    return 0;
                }
                else
                {
                    return (mounts - 6) * this.InterestRate;
                }
            }
            else
            {
                throw new TypeUnloadedException("unknown customer type");
            }
        }

        public MortgageAcc(decimal balance, Customer client, decimal interest):base(balance,client,interest)
        {
        }
            
    }
}
