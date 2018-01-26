using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Program Factorial of a number");

            bool run = true;
                while (run) {
                Console.WriteLine("Enter a number between 1-20:");

                int x = int.Parse(Console.ReadLine());
                if (x <= 20 && x >= 0)
                {
                    Console.WriteLine("The factorial of "+x+"  is " + factoRecursion(x));
                }
                else
                    Console.WriteLine("Number out of range");

                run = continue_run();

                
            }// end of while loop
        }
        public static bool continue_run()
        {

            Console.Write("Continue?(Y/N) : ");
            string response = Console.ReadLine();
            response = response.ToLower();
            if (response == "y")
            {
                return true;
            }
            else if (response == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("You did not type a recognized caracter, type Y or N");

                return continue_run();
            }

        }
        public static long factoRecursion( int x)
        {
            if (x == 0 ||x == 1) return 1;
            return x * factoRecursion(x - 1);

        }
        public static long factoFor(int x)
        {
            long facto = 1;
            for (int i = 1; i <= x; i++)

            {
                facto *= i;

            }
            return facto;
        }
    }
}
