using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringSimpleWrongWritenClasses
{
    enum Sex
    {
        Male,
        Female
    }
    public class Human
    {
        public Sex humanSexValue
        {
            get;
            set;
        }
        public string HumanName
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
    }
    public static class HumanFactory
    {
        public const string MALE_DEFAULT_NAME = "Батката";
        public const string FEMALE_DEFAULT_NAME = "Мацето";


        public void MakeHuman(int humansAge)
        {
            Human newHuman = new Human();
            newHuman.Age = humansAge;

            if (humansAge % 2 == 0)
            {
                newHuman.HumanName = MALE_DEFAULT_NAME;
                newHuman.humanSexValue = Sex.Male;
            }
            else
            {
                newHuman.HumanName = FEMALE_DEFAULT_NAME;
                newHuman.humanSexValue = Sex.Female;
            }
        }
    }
}
