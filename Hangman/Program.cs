using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Hangman!!!!!!!!!!");
            string[] listwords = new string[10];
            listwords[0] = "sheep";
            listwords[1] = "goat";
            listwords[2] = "computer";
            listwords[3] = "america";
            listwords[4] = "watermelon";
            listwords[5] = "icecream";
            listwords[6] = "jasmine";
            listwords[7] = "pineapple";
            listwords[8] = "orange";
            listwords[9] = "mango";
            Random randGen = new Random();
            var idx = randGen.Next(0, 9);
            string mysteryWord = listwords[idx];
            char[] guess = new char[mysteryWord.Length];
            Console.Write("Please enter your guess: ");
            int numGuess = 0;
            for (int p = 0; p < mysteryWord.Length; p++)
                guess[p] = '-';

            while (numGuess<=mysteryWord.Length+3)
            {
                char playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < mysteryWord.Length; j++)
                {
                    if (playerGuess == mysteryWord[j])
                        guess[j] = playerGuess;
                }
                Console.WriteLine(guess);
                String s= new String(guess);
                Console.WriteLine(s);
                if(s==(mysteryWord))
                {
                    Console.WriteLine("Congratulations");
                    break;
                    
                }
                numGuess++;
                if (numGuess == mysteryWord.Length + 3)
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                
            }
            
        }
    }
}