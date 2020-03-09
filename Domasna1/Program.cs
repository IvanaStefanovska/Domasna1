using System;

namespace Domasna1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Task 6

            Console.WriteLine("Input two numbers");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"The firstNumber is larger than the secondNumber");
            }
            else
            {
                Console.WriteLine($"The secondNumber is larger than the firstNumber");

            }

            if (firstNumber % 2 == 0)
            {
                Console.WriteLine($"The input number: {firstNumber} is an even number!");
               }
            else
            {
                Console.WriteLine($"The input number: {firstNumber} is an odd number!");
            }

            if (secondNumber % 2 == 0)
            {
                Console.WriteLine($"The input number: {secondNumber} is an even number!");
            }
            else
            {
                Console.WriteLine($"The input number: {secondNumber} is an odd number!");
            }

                Console.ReadLine();


            //Task 7

            Console.WriteLine("Please enter number between 1 and 3");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
            case 1:
             Console.WriteLine("You got a new car !");
                break;
             case 2:
            Console.WriteLine("You got a new plane !");
                break;
             case 3:
             Console.WriteLine("You got a new bike !");
                break;
             default:
             Console.WriteLine("You have entered wrong number !");
                break;
            }

        }
    }
}
