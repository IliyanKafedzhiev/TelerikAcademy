using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{
    public class Individual : Customer
    {
        public override string DefineCostumer()
        {
            return "Individual";
        }
    }
}
