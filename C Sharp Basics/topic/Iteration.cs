using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.topic
{
    public class Iteration
    {
        /*For loop
        ForEach
        While Loop
        Do-While Llop*/

        public static void findRandomNumber()
        {
            Console.WriteLine("Welcome to the GAME \n System will generate the random number b/w 1 to 10 \n" +
                "You have to find the number");
            Console.WriteLine("   ");
            
            var chances = 4;
            var randomNumber = new Random().Next(1, 11);
            
            for(int i = chances; i>=1; i--)
            {
                Console.WriteLine("Hey, you ! You have only {0} chance", i);
                Console.WriteLine("Enter a number");
                var userInput = Convert.ToInt32(Console.ReadLine());
                if (randomNumber == userInput)
                {
                    Console.WriteLine("Hurray you win the 1 core cash money");
                    break;
                }
            }
            
        }
    }
}
