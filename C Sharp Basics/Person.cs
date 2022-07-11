using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Person
    {
        public string firstName;
        public string lastName;
        public DateOnly dob;
        public int age;

        public void intro()
        {
            Console.WriteLine("My name is {0} and my age is {1}", firstName, age);
        }
    }
}
