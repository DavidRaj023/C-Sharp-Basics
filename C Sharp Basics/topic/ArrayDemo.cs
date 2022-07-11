using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.topic
{
    public class ArrayDemo
    {
        public static void getDemo(int[] numbers) 
        {
            //Length
            Console.WriteLine("Length of the given number " + numbers.Length);

            //IndexOf
            Console.WriteLine("Index of 3 is: " + Array.IndexOf(numbers, 3));

            //Copy
            Console.WriteLine("Effoct of copy");
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach(int i in another)
            {
                Console.WriteLine(i);
            }

            //sort
            Console.WriteLine("Effoct of sort");
            Array.Sort(numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            //Reverse
            Console.WriteLine("Effoct of reverse");
            Array.Reverse(numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

        }
    }
}
