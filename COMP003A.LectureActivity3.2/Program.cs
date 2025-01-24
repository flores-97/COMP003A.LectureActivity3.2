/*Author: Victor Flores
 Course: COMP-003A
Faculty: Jonathon Cruz
Purpose: Demonstrate selection statements in C#*/
namespace COMP003A.LectureActivity3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Selection Statements Demo!");

            //prompt user for hour in 24 hr 
            Console.Write("Enter the current hour (00-23): ");
            int hour = int.Parse(Console.ReadLine());

            //Con 1: From 05-11
            //Con 2: from 12-17
            //Con 3: From 18-20
            //Con 4: from 21-04
            if (hour >= 5 && hour <= 11)
            {
                Console.WriteLine("Good Morning!");
            }
            else if (hour >= 12 && hour <= 17)
            {
                Console.WriteLine("Good Afternoon!");
            }

            else if (hour >= 18 && hour <= 20)
            {
                Console.WriteLine("Good Evening!");
            }

            else
            {
                Console.WriteLine("Good Night!)");
            }

            //prompt day of the week
            Console.Write("Enter the day of the week: ");
            string day = Console.ReadLine();

            /*Con 1: Monday
             Con 2: Friday
            Con 3: Sunday
            default: Just another day*/
            switch (day.ToLower())
            {
                case "monday":
                    Console.WriteLine("Start of the work week.");
                    break;
                case "friday":
                    Console.WriteLine("Almost the weekend!");
                    break;
                case "sunday":
                    Console.WriteLine("Relax, it's Sunday.");
                    break;
                default:
                    Console.WriteLine("Just another day.");
                    break;
            }

        }
    }

}
