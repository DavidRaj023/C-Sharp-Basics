using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.topic
{
    public class ReferenceAndValueTypes
    {
        public static void getDemo()
        {
            //Value Type:
            int a = 24;
            int b = a;
            b++;

            Console.WriteLine("Value Type Example");
            Console.WriteLine("A: {0}, B: {1}", a, b);

            //Reference Type:
            var array1 = new int[] { 1, 2, 3, 4, 5, 6 };
            var array2 = array1;
            array2[3] = 10;
            Console.WriteLine(array1[3]);
        }


    }
}
