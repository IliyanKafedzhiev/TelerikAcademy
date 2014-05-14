using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.Animals;

    class Test
    {
        static void Main(string[] args)
        {
            Animals[] arrayOfAnimals = new Animals[] { new Dog("Bayy Bayy !!", 6, "Lucky", true), new Frog("Kwak Kwak", 1, "Jabka", true),
            new Cat("Mqyy Mqyy", 4, "Tom", true),new Tomcat("Mqyy Mqyy", 1, "Tomcho"),new Kittens("Mqyy Mqyy", 1, "Maccaaa")};
            Console.WriteLine(AverageAge(arrayOfAnimals));
        }
        static double AverageAge (Animals[] animals)
        {
            double sum = 0;
            int counter = 0;
            foreach (Animals animal in animals)
            {
                counter++;
                sum += animal.Age;
            }
            return sum / counter;
        }
    }
