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
            Console.WriteLine(" --------------------");
            Console.WriteLine("| Welcome to Hangman |");
            Console.WriteLine(" --------------------");
            string[] listwords = new string[11];
            listwords[0] = "dinosaur";
            listwords[1] = "scheme";
            listwords[2] = "marlboro";
            listwords[3] = "ignorant";
            listwords[4] = "thiruvananthapuram";
            listwords[5] = "synthetic";
            listwords[6] = "claustrophobia";
            listwords[7] = "gibberish";
            listwords[8] = "stethoscope";
            listwords[9] = "butterscotch";
            /*listwords[10] = "claustrophobia";
            listwords[11] = "gibberish";*/
            bool flag;
            Random randGen = new Random();
            var idx = randGen.Next(0, 9);
            string mysteryWord = listwords[idx];
            Console.WriteLine("It is a {0} letter word",mysteryWord.Length);
            char[] guess = new char[mysteryWord.Length];
            Console.Write("Please enter your guess: ");
            int numGuess = 0;
            for (int p = 0; p < mysteryWord.Length; p++)
                guess[p] = '-';

            while (numGuess<=mysteryWord.Length+2)
            {
                flag = false;
                char playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < mysteryWord.Length; j++)
                {
                    if (playerGuess == mysteryWord[j])
                    {
                        guess[j] = playerGuess;
                        //Console.WriteLine(flag);
                        flag = true;
                        //Console.WriteLine(flag);
                    }
                    
                    
                }
               // Console.WriteLine(flag);
                if (flag == false) { numGuess++; }
                Console.WriteLine(guess);
                String s= new String(guess);
                if(s==(mysteryWord))
                {
                    Console.WriteLine("Congratulations");
                    break;
                    
                }
                
                if (numGuess == mysteryWord.Length + 2)
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                
            }
            
        }
    }
}