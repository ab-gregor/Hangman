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
            List<string> words = new List<string>();
            words.Add("dinosaur");
            words.Add("scheme");
            words.Add("marlboro");
            words.Add("ignorant");
            words.Add("thiruvananthapuram");
            words.Add("synthetic");
            words.Add("claustrophobia");
            words.Add("gibberish");
            words.Add("stethoscope");
            words.Add("butterscotch");
            bool flag;
            Random randGen = new Random();
            var idx = randGen.Next(0, words.Count);
            string mysteryWord = words[idx];
            Console.WriteLine("It is a {0} letter word",mysteryWord.Length);
            char[] guess = new char[mysteryWord.Length];
            Console.Write("Please enter your guess: ");
            int numGuess = 0;
            for (int p = 0; p < mysteryWord.Length; p++)
                guess[p] = '-';

            while (numGuess<=mysteryWord.Length)
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
                    Console.WriteLine(" ------------------------------------");
                    Console.WriteLine("****Congratulations****");
                    Console.WriteLine("     You have Won at last");
                    break;
                    
                }
                
                if (numGuess == mysteryWord.Length )
                {
                    Console.WriteLine(" ------------------------------------");
                    Console.WriteLine("!!!!!Game Over!!!!!!");
                    Console.WriteLine("     Try Harder");
                    break;
                }
                
            }
            
        }
    }
}