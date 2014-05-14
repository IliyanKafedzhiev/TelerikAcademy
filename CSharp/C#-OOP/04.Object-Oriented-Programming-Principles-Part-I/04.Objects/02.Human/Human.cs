using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Human
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value != null)
                {
                    firstName = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value != null)
                {
                    lastName = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public Human(string first,string second)
        {
            FirstName = first;
            LastName = second;
        }
    }
}
