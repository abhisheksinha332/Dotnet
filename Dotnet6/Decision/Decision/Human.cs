using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision
{
    internal class Human
    {
        public string firstname;
        private string lastname;   
        private int age;
        private string firstName;
        private string lastName;
        private string eyeColor;

        public void intro()
        {
            Console.WriteLine("Hi there, I am {0}", firstname);
            Console.WriteLine();
        }
        public void introduction()
        {
            Console.WriteLine("I am {0} {1} and my eye color is {2} and my age is {3}", firstName, lastName, eyeColor, age);
        }


        //Constructors
        public Human(string firstName, string lastName) {
            Console.WriteLine("Hello I am {0} {1}", firstName, lastName);
        }

        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName; 
            this.lastName = lastName;   
            this.age = age;
            this.eyeColor = eyeColor;
        }
        
    }
}
