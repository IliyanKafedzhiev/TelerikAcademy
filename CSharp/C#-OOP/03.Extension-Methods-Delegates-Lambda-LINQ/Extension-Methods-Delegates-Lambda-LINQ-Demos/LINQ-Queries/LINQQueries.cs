using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3_StudentsNameCompare
{
    class Student
    {
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        { get; set; }
        public int Age
        { get; set; }
        public Student(string firstName, string lastName, int Age = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            this.Age = Age;
        }
    }
    static class Program
    {
        static void Print<T>(this IEnumerable<T> collection)
        {
            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }

        static void Exersize3()
        {
            List<Student> listOfStudents = new List<Student>();
            listOfStudents.Add(new Student("Ivan", "Rusev"));
            listOfStudents.Add(new Student("Georgi", "Antonov"));
            listOfStudents.Add(new Student("Mincho", "Praznikov"));
            listOfStudents.Add(new Student("Angel", "Tomov"));
            listOfStudents.Add(new Student("Zlatan", "Vanev"));
            listOfStudents.Add(new Student("Genaro", "Gatuzzo"));
            listOfStudents.Add(new Student("Mitio", "Fibata"));

            var selection =
                from students in listOfStudents
                orderby students.LastName
                where students.FirstName.CompareTo(students.LastName) < 0
                select students;
            foreach (var item in selection)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
        static void Exersize4()
        {
            List<Student> listOfStudents = new List<Student>();
            listOfStudents.Add(new Student("Ivan", "Rusev",18));
            listOfStudents.Add(new Student("Georgi", "Antonov",44));
            listOfStudents.Add(new Student("Mincho", "Praznikov",32));
            listOfStudents.Add(new Student("Angel", "Tomov",20));
            listOfStudents.Add(new Student("Zlatan", "Vanev",19));
            listOfStudents.Add(new Student("Genaro", "Gatuzzo",25));
            listOfStudents.Add(new Student("Mitio", "Fibata",24));

            var selection =
                from students in listOfStudents
                orderby students.LastName
                where students.Age >= 18 && students.Age <= 24 
                select students;
            foreach (var item in selection)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
        static void Exersize5()
        {
            List<Student> listOfStudents = new List<Student>();
            listOfStudents.Add(new Student("Ivan", "Rusev", 18));
            listOfStudents.Add(new Student("Georgi", "Antonov", 44));
            listOfStudents.Add(new Student("Mincho", "Praznikov", 32));
            listOfStudents.Add(new Student("Angel", "Tomov", 20));
            listOfStudents.Add(new Student("Zlatan", "Vanev", 19));
            listOfStudents.Add(new Student("Genaro", "Gatuzzo", 25));
            listOfStudents.Add(new Student("Mitio", "Fibata", 24));

            var sortedStudents = listOfStudents.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
            Console.WriteLine();
            Console.WriteLine("Sorted students by first and family name for task 5 with OrderBy() and ThenBy():");
            Print(sortedStudents);

            var sortedStudentsLINQ = from student in listOfStudents
                                     orderby student.FirstName descending, student.LastName descending
                                     select student;
            Console.WriteLine();
            Console.WriteLine("Sorted students by first and family name for task 5 with LINQ:");
            Print(sortedStudentsLINQ);
        }
        static void Exersize6()
        {
            int[] numbers = new int[] { 3, 7, 21, 12, 15, 17, 42, 255, 63, 0 };
            var multipliers = numbers.Where(x => x % 21 == 0);
            var multipliersLINQ = from number in numbers
                                  where number % 21 == 0
                                  select number;
            Console.WriteLine("Initial sequence:");
            Print(numbers);
            Console.WriteLine("Multipliers of 3 and 7 using extension methods:");
            Print(multipliersLINQ);
            Console.WriteLine("Multipliers of 3 and 7 using LINQ:");
            Print(multipliers);
        }
        static void Main(string[] args)
        {
            //Exersize3();
           // Exersize4();
            //Exersize5();
            Exersize6();
        }
    }
}