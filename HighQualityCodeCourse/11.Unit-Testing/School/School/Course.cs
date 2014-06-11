using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikSchool
{
    public class Course
    {
        private ICollection<Student> students;

        public ICollection<Student> Students
        {
            get
            {
                if (students == null)
                {
                    students = new List<Student>();
                }
                return students;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                if (value.Count > 30)
                {
                    throw new ArgumentException();
                }

                this.students = value;
            }
        }

        public Course(ICollection<Student> candidates)
        {
            this.Students = candidates;
        }

        public Course()
        {
            this.students = new List<Student>();
        }

        public void Join(Student candidate)
        {
            if (candidate == null)
            {
                throw new ArgumentNullException();
            }
            if (Students.Count == 30)
            {
                throw new OverflowException("Courses can support less than 30 students");
            }
            this.Students.Add(candidate);
        }

        public void Leave(Student studentForLeave)
        {
            Students.Remove(studentForLeave);
        }
    }
}
