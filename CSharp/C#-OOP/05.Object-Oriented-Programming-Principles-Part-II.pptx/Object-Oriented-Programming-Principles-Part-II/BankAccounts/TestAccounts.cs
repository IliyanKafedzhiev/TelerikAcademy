using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class TestAccounts
    {
        static void Main(string[] args)
        {
            Customer[] clients = new Customer[]{new Individual(),new Companie()};
            BankAccount[] accounts = new BankAccount[] { new MortgageAcc(20000, clients[0], 4), new DepositAcc(20000, clients[0], 4)
            ,new LoanAcc(20000,clients[0],4),new MortgageAcc(20000,clients[1],4),new DepositAcc(20000, clients[1], 4)
            ,new LoanAcc(20000,clients[1],4)};

            foreach (BankAccount account in accounts)
            {
                Console.WriteLine("I'm  "+account.GetType().Name+" ,My Interest for 12 mounths is "+account.InterestAmountForPereiod(12));
            }
            Bank AlphaBank = new Bank(accounts);
        }
    }
}
