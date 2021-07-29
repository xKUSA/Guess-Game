using System;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "giraffe";
            string guess = "";
            int GuessCount = 0;
            int GuessLimit = 3;
            bool OutOfGuesses = false;

            while (guess != word && !OutOfGuesses)
            {
                if (GuessCount < GuessLimit)
                {
                    Console.Write("Enter your guess: ");
                    guess = Console.ReadLine();
                    GuessCount++;
                }
                else
                {
                    OutOfGuesses = true;


                }
                if (OutOfGuesses)
                {
                    Console.WriteLine("You Lose");
                }
            }
            
               if (guess == word)
                {
                    Console.WriteLine("You Won ! ");    
                } 
               
            



            Console.ReadLine();

        }    
    }
}
