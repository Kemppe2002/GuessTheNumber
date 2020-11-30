using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(101); //Creates a random number
            int attempts = 1;

            Console.WriteLine("Guess a number between 1 and 100:");
            int guess = Convert.ToInt32(Console.ReadLine()); //Your guess

            while (guess != randomnumber) //Loop makes it possible to try until you get it right
            {
                attempts++; //Counts your attempts

                if (guess < randomnumber) //Tells if guess is too high or low
                {
                    Console.WriteLine("Too low, try again!");
                }
                else if (guess > randomnumber)
                {
                    Console.WriteLine("Too high, try again!");
                }

                if (attempts == 7) //skämt, snälla sänk inte mitt betyg
                {
                    Console.WriteLine("Wow you are really bad at this game xD");
                }
                else if (attempts > 7)
                {
                    Console.WriteLine("You can do it!");
                }

                Console.WriteLine(); //Extra line between makes it easier to read
                guess = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("You guessed right!");
            Console.WriteLine("Number of attemts: " + attempts);
        }
    }
}
