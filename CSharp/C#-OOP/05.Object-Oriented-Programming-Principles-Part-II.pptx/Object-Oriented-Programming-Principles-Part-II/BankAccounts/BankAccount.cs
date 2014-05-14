using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{
    public abstract class BankAccount
    {
        private Customer custumer;
        private decimal balance;
        private decimal interestRate;

        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public Customer Customer
        {
            get
            {
                return this.custumer;
            }
            set
            {
                this.custumer = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                this.interestRate = value;
            }
        }

        // Methods
        public abstract void Deposit(decimal sum);
        public virtual void WithDraw(decimal sum)
        {
            Console.WriteLine("this method is unrechable for current client");
        }
        public virtual decimal InterestAmountForPereiod(int mounts)
        {
            return mounts * InterestRate;
        }
        public BankAccount(decimal balance,Customer client,decimal interest )
        {
            this.custumer = client;
            this.balance = balance;
            this.interestRate = interest;
        }
    }
}
