using System;
using System.Threading.Tasks;

namespace C_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1,11);
            int guess;
            int numberOfGuesses = 6;
            bool gameOver = false;
            int guessCount = 0;

            Console.WriteLine("Please Enter Your Guess!");

            while(gameOver==false && guessCount<numberOfGuesses)
            {
                guess=int.Parse(Console.ReadLine());
                numberOfGuesses--;

                if (guess != randomNumber && numberOfGuesses == 0)
                {
                    Console.WriteLine("Ooops, You have used up all available guessing power. GAME OVER!");
                    gameOver=true;
                }
                else if(guess == randomNumber)
                {
                    Console.WriteLine("You got it Right!");
                    gameOver= true;
                }
                else if(guess != randomNumber)
                {
                    Console.WriteLine("That was wrong!");
                    gameOver=true;
                }
                else if(guess > randomNumber)
                {
                    Console.WriteLine("There are three levels,easy,medium and hard");
                    
                }
            }
        }
    }
}
