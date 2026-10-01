using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6___Loops
{
    internal class Program
    {
        static void Main(string[] args) //Maxym F.
        {
            for (int i = 1; i <= 10; i++) //i++ is the same as i = i + 1 and i += 1
            {
                Console.WriteLine("Hello!");
            }

            //1

            for (int i = 1; i <= 10; i++) 
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();
            
            //2

            for (int i = 5; i <= 50; i = i + 5) 
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            //3

            for (int i = 99; i >= 55; i--) 
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            //4

            int evenSum = 0;
            
            int oddSum = 0;

            for (int i = 20; i <= 40; i++)
            {
                if (i % 2 == 0) //If i is divisible by 2 it is even
                {
                    evenSum += i;
                }
                else  //If i is not divisible by 2 it is odd
                {
                    oddSum += i;
                }
            }
            Console.WriteLine($"Sum of odd numbers: {oddSum}");
            Console.WriteLine($"Sum of even numbers: {evenSum}");

            Console.WriteLine();

            //5

            // 5! = 5 x 4 x 3 x 2 x 1
            int factorial = 1;
            for (int i = 5; i >= 1; i--)
            {
                factorial *= i;
            }
            Console.WriteLine($"5! = {factorial}");

            Console.WriteLine();

            //6

            int numEven = 0;
            int input;
            Console.WriteLine("Enter 10 integers, I will tell you how many are even!");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter an integer:");
                while (!Int32.TryParse(Console.ReadLine(), out input)) //Ensures valid input
                    Console.WriteLine("Invalid integer, try again:");
                if (input % 2 == 0) //If there is only 1 line of code in the body of a loop or if statement, the { } are optional!
                    numEven += 1;
            }
            Console.WriteLine($"You entered {numEven} even numbers.");




        }
    }
}
