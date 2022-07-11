using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Basics.collections
{
    public class ArrayListDemo
    {
        public static void getArrayListDemo()
        {
            /*Arraylist is a class that is similar to an array, but it can be used to store values of various types.
            An Arraylist doesn't have a specific size.
            Any number of elements can be stored.*/

            var arraylist = new ArrayList();
            //To add
            arraylist.Add("One");
            arraylist.Add(1);
            arraylist.Add(DateTime.Now);
            arraylist.Add(23);
            arraylist.Add(24);
            arraylist.Add("One");
            arraylist.Add("One");
            arraylist.Add("One");
            arraylist.Add("One");


            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Current Array list Capacity is {0}", arraylist.Capacity);
            Console.WriteLine("Index of 1 is " + arraylist[1]);

            Console.WriteLine("=====Modified List======");
            /*//To Insert
            arraylist.Insert(1, "two");
            //To remove 
            arraylist.Remove("One");
            //To remove specific index
            arraylist.RemoveAt(3);
            //To Specific Range
            arraylist.RemoveRange(0, 2);
            //To clear
            arraylist.Clear();*/
            //To Sort
            arraylist.Sort();

            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
