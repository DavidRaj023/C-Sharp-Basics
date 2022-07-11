using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.topic
{
    public class ControlFlow
    {
        public static void checkEmployeeStatus(int statusId)
        {
            switch (statusId)
            {
                case 0:
                    Console.WriteLine("active");
                    break;
                case 1:
                    Console.WriteLine("resigned");
                    break ;
                case 2:
                    Console.WriteLine("retired");
                    break;
                case 3:
                    Console.WriteLine("terminated");
                    break;
                case 4:
                    Console.WriteLine("suspended");
                    break;
                default:
                    Console.WriteLine("Please enter the valid statusId");
                    break;
            }
        }
    }
}
