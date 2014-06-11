using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikSchool
{
    public class Student
    {
        private string name;
        private int id;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Name of a student is empty string ! or null");
                }

                if (value == null)
                {
                    throw new ArgumentNullException("null reference as a name of a student");
                }

                this.name = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentException("Id of a student is not set correctly ,should be in this range [10000-99999]");
                }

                this.id = value;
            }
        }

        public Student(string nameOfStudent,int idOfStudent)
        {
            this.Name = nameOfStudent;
            this.Id = idOfStudent;
        }

        public override bool Equals(Object obj)
        {
            return (((Student)obj).Name == Name) && (((Student)obj).Id == Id);
        }
    }
}
