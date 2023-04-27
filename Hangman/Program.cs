using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman
{
    class Score
    {
        public static List<int> score = new List<int>();
    }
    class Program:Score
    {
        
        static void Main()
        {
            
            Console.WriteLine(" --------------------");
            Console.WriteLine("| Welcome to Hangman |");
            Console.WriteLine(" --------------------");
            string[] listwords = new string[11];
            List<String> animals = new List<String>();
            List<String> vehicles= new List<String>();
            List < KeyValuePair<string, List<string>>> CategoryWords=new List<KeyValuePair<string, List<string>>>();
            CategoryWords.Add(new KeyValuePair<string, List<string>>("Animals",animals));
            CategoryWords.Add(new KeyValuePair<string, List<string>>("Vehicles", vehicles));
            animals.Add("dinosaur");
            animals.Add("chameleon");
            animals.Add("iguana");
            vehicles.Add("volkswagen");
            vehicles.Add("ford");
            vehicles.Add("bmw");
            Console.WriteLine("Select Category");
            Console.WriteLine("1.Animals \n 2.Vehicles");
            int ch=Convert.ToInt32(Console.ReadLine());
            List<string> words = new List<string>();
            if(ch==1)
            {
                words = animals;
            }
            else if (ch == 2)
            {
                words= vehicles;
            }
            
            bool flag;
            Random randGen = new Random();
            var idx = randGen.Next(0, words.Count);
            string mysteryWord = words[idx];
            Console.WriteLine("It is a {0} letter word", mysteryWord.Length);
            char[] guess = new char[mysteryWord.Length];
            Console.Write("Please enter your guess: ");
            int numGuess = 0;
            for (int p = 0; p < mysteryWord.Length; p++)
                guess[p] = '-';

            while (numGuess <= mysteryWord.Length)
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
                String s = new String(guess);
                if (s == (mysteryWord))
                {
                    Score.score.Add(100 - numGuess);
                    Console.WriteLine(" ------------------------------------");
                    Console.WriteLine("****Congratulations****");
                    Console.WriteLine("     You have Won at last ");
                    Console.WriteLine("Your Score: {0}", (100 - numGuess));

                    Console.WriteLine("High score: {0}", Score.score.Max());
                    Console.WriteLine();
                    Console.WriteLine("Enter your option: ");
                    Console.WriteLine("1. Restart, 2. Quit");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        Main();
                    }
                    else
                    {
                        Environment.Exit(1);
                    }

                }

                if (numGuess == mysteryWord.Length)
                {
                    Console.WriteLine(" ------------------------------------");
                    Console.WriteLine("!!!!!Game Over!!!!!!");
                    Console.WriteLine("     Try Harder");
                    Console.WriteLine();
                    Console.WriteLine("Enter your option: ");
                    Console.WriteLine("1. Restart, 2. Quit");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        Main();
                    }
                    else
                    {
                        Environment.Exit(1);
                    }
                }

            }

        }
    }
}