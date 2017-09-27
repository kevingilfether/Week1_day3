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

            //Console.WriteLine("What day of the week is it?");
            //string userAnswer = Console.ReadLine();

            //if (userAnswer == "Monday")
            //{
            //    Console.WriteLine("Back to work.");
            //}
            //else if (userAnswer == "Friday")
            //{
            //    Console.WriteLine("TGIF!!!");
            //}
            //else
            //{
            //    Console.WriteLine("Bloop. (You got it.)");
            //}

            //Console.WriteLine("How old are you?");
            //int userAge = int.Parse(Console.ReadLine());

            //if(userAge >= 0 && userAge <= 1)
            //{ 
            //    Console.WriteLine("You're just a baby!");
            //}
            //else if(userAge > 1 && userAge < 4)
            //{
            //    Console.WriteLine("Yay toddlers!");
            //}
            //else if (userAge >=4 && userAge < 13)
            //{
            //    Console.WriteLine("Enjoy your childhood");
            //}
            //else if(userAge >=13 && userAge < 65)
            //{
            //    Console.WriteLine("Life is awkward.");
            //}
            //else if(userAge >= 65 && userAge < 100)
            //{
            //    Console.WriteLine("Enjoy your retirement.");
            //}
            //else
            //{
            //    Console.WriteLine("That's not really your age...");
            //}



            // New type of conditional! This time it's the switch statement.

            //Console.WriteLine("How many points did you earn?");
            //int pointsEarned = int.Parse(Console.ReadLine());

            //switch (pointsEarned)
            //{
            //    case 0:
            //        Console.WriteLine("You Lose.");
            //        break;
            //    case 1:
            //        Console.WriteLine("Needs practice.");
            //        break;
            //    case 2:
            //        Console.WriteLine("On target");
            //        break;
            //    case 3:
            //        Console.WriteLine("Supertsar.");
            //        break;
            //    case 4:
            //        Console.WriteLine("Overachiever!");
            //        break;
            //    case 5:
            //        Console.WriteLine("You cheated.");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid score entered.");
            //        break;

            //}

            //int shareOfDinner = 13;
            //int numDiners = 4;
            //int totalDinnerCost = shareOfDinner * numDiners;
            //Console.WriteLine ("The dinner cost $" + totalDinnerCost + ".");

            Console.WriteLine("Enter how much each diner pays:");
            double shareOfDinner = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter how many diners you have:");
            int numDiners = int.Parse(Console.ReadLine());

            double totalDinnerCost = shareOfDinner * numDiners;
            
            if (totalDinnerCost >= 50)
            {
                totalDinnerCost = totalDinnerCost * 0.9d;
                Console.WriteLine("Congrats, you got a 10% discount! The dinner cost $" + totalDinnerCost + ".");
            }
            else
            {
                totalDinnerCost = totalDinnerCost * 0.95d;
                Console.WriteLine("Congrats, you got a 5% discount! The dinner cost $" + totalDinnerCost + ".");
            }
            Console.ReadKey();



        }
    }
}
