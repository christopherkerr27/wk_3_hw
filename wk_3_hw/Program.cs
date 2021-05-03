using System;

namespace wk_3_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Select a number between 1-12");
            //var userInput = Convert.ToInt32(Console.ReadLine());
            //if (userInput >= 1 && userInput <= 12)
            //{

            //    switch (userInput)
            //    {
            //        case 1:
            //            Console.WriteLine("January");
            //            break;
            //        case 2:
            //            Console.WriteLine("February");
            //            break;
            //        case 3:
            //            Console.WriteLine("March");
            //            break;
            //        case 4:
            //            Console.WriteLine("April");
            //            break;
            //        case 5:
            //            Console.WriteLine("May");
            //            break;
            //        case 6:
            //            Console.WriteLine("June");
            //            break;
            //        case 7:
            //            Console.WriteLine("July");
            //            break;
            //        case 8:
            //            Console.WriteLine("August");
            //            break;
            //        case 9:
            //            Console.WriteLine("September");
            //            break;
            //        case 10:
            //            Console.WriteLine("October");
            //            break;
            //        case 11:
            //            Console.WriteLine("November");
            //            break;
            //        case 12:
            //            Console.WriteLine("December");
            //            break;

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("You didn't select a number between 1-12");
            //}
            //Console.WriteLine("Press enter to exit");
            //Console.ReadLine();


            Console.WriteLine("Choose between 3 trivia categories: (sports, science or pop culture)");
            var userInput = Console.ReadLine();
            if (userInput == "sports" || userInput == "science" || userInput == "pop culture")
            {


                switch (userInput)
                {
                    case "sports":
                        Console.WriteLine("What's the diameter of a basketball hoop in inches?");
                        break;
                    case "science":
                        Console.WriteLine("What is consciousness?");
                        break;
                    case "pop culture":
                        Console.WriteLine("What is a Justin Bieber?");
                        break;
                }
            }
            else
            {
                Console.WriteLine("You didn't pick a proper catergory. Please try again.");
            }
                Console.WriteLine("Press enter to exit.");
                Console.ReadLine();
            }
        }

    }
