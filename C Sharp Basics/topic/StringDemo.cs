using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.topic
{
    public class StringDemo
    {
        public static void demoString()
        {
            Console.WriteLine("String demo");
            string firstName = "David";
            string lastName = "Raj";

            /*string fullName = firstName + " " + lastName;*/
            string fullName = string.Format("My full name is {0}{1}", firstName, lastName);

            Console.WriteLine(fullName);

            string[] names = new string[3] { "David", "Raj", "kumar" };

            string foramtedString = string.Join(", ", names);
            Console.WriteLine(foramtedString);

            //string path = "c:\\folder\\files\\file";
            //or we can use @ symbol before the string to format it.
            string path = @"c:\folder\files\file";
            Console.WriteLine(path);

        }
    }
}
