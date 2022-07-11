using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Basics.collections
{
    public class StackDemo
    {
        public static void getStackDemo()
        {
            var stack = new Stack();
            var stackGn = new Stack<String>();

            stack.Push("David");
            stack.Push(23);
            stack.Push(DateTime.Now);
            stack.Pop();

            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("The Peek element: "+ stack.Peek());
            stack.Clear();
            Console.WriteLine("23 Containe in Stack? :" + stack.Contains(23));


        }
    }
}
