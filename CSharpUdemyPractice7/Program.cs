using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUdemyPractice7
{
    class Program
    {
        static void Main(string[] args)
        {   //Write a program that picks a random number between 1 and 10. Give the user 4 chances to
            //guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". 
            //(To make sure the program is behaving correctly, you can display the secret number on the console first.)

            var random = new Random();
            var attempts = 1;
            int guess;
            var numberToGuess = random.Next(1, 10);
            Console.WriteLine(numberToGuess);
            do
            {
                Console.WriteLine("Please enter a number between 1 and 10: ");
                guess = int.Parse(Console.ReadLine());
                if (guess != numberToGuess)
                {
                    Console.WriteLine("You lost.");
                    attempts++;

                }
                else
                {
                    Console.WriteLine("Yay! You won.");
                    break;
                }

            } while (attempts <= 4);
        }
    }
}
