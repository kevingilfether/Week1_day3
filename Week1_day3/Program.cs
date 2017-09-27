using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_day3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conditionals - If then, if else, etc.

            //int firstNumber = 2;
            //int secondNumber = 6;

            //if(firstNumber > secondNumber)
            //{
            //    // Do Something
            //    Console.WriteLine("This is an untrue expression. You messed up.");
            //}
            //else
            //{
            //    Console.WriteLine("That makes sense.");
            //}

            Console.WriteLine("What day of the week is it?");
            string userAnswer = Console.ReadLine();

            if (userAnswer == "Monday")
            {
                Console.WriteLine("Back to work.");
            }
            else if (userAnswer == "Friday")
            {
                Console.WriteLine("TGIF!!!");
            }
            else
            {
                Console.WriteLine("Bloop. (You got it.)");
            }





        }
    }
}
