using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Human
{
    public class Student : Human
    {
        private int grade;

        public int Grade
        {
            get
            {
                return grade;
            }
            set
            {
                if (value != null)
                {
                    value = grade;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public Student(string first, string second , int grade):base(first,second)
        {
            Grade = grade;
        }

        static void Main()
        {
            Student[] students = new Student[] { new Student("Pesho", "Peshkow", 5), new Student("Pesho", "Peshkow", 7), new Student("Pesho", "Peshkow", 1),
            new Student("Pesho", "Peshkow", 9),new Student("Pesho", "Peshkow", 10),new Student("Pesho", "Peshkow", 2),new Student("Pesho", "Peshkow", 13),
            new Student("Pesho", "Peshkow", 8),new Student("Pesho", "Peshkow", 6),new Student("Pesho", "Peshkow", 11)};
            var selection =
                from St in students
                orderby St.Grade
                //where St.Grade.CompareTo(St.Grade) < 0
                select St;
            foreach (var item in selection)
            {
                Console.WriteLine(item.Grade);
            }
        }
    }
}
