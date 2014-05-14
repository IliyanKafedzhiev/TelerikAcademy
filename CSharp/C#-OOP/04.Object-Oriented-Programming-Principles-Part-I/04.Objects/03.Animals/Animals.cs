using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Animals
{
    public abstract class Animals : ISound
    {
        private string specificSound;
        private int age;
        private string name;
        private bool sexIsMale;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != null)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }

        public bool SexIsMale
        {
            get
            {
                return sexIsMale;
            }
            set
            {
                sexIsMale = value;
            }
        }

        public string SpecificSound
        {
            get
            {
                return specificSound;
            }
            set
            {
                if (value != null)
                {
                    specificSound = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
    
        public void playSound()
        {
            Console.WriteLine("The sound that animal emit is : \""+specificSound + "\"");
        }

        public Animals(string sSound,int age , string name, bool isMale)
        {
            SpecificSound = sSound;
            Age = age;
            SexIsMale = isMale;
            Name = name;
        }
    }
}
