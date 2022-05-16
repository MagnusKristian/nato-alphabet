using System;

namespace kodeMedLinn // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var m = new Class1("Magnus","kjører motorsykkel",25);
            //Console.WriteLine(m.Name);

            string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "æ", "ø", "å" };
            string[] words = { "ALFA", "BRAVO", "CHARLIE", "DELTA", "ECHO", "FOXTROT", "GOLF", "HOTEL", "INDIA", "JULIET", "KILO", "LIMA", "MIKE", "NOVEMBER", "OSCAR", "PAPA", "QUEBEC", "ROMEO", "SIERRA", "TANGO", "UNIFORM", "VICTOR", "WHISKEY", "X-RAY", "YANKEE", "ZULU", "ÆRLIG", "ØSTEN", "ÅSE" };
            var random = new Random();
            int score = 0;
       
            Console.WriteLine("Natophonetic alphabet:");
            Console.WriteLine("Heres a letter, what is its natophonetic word?");
            
            int counter = 0;
            int rightCounter = 0;
            int wrongCounter = 0;
            
            while (true)
            {
                int randomNumber = random.Next(0, alphabet.Length + 1);
                string correctAnswer = words[randomNumber];
                Console.WriteLine($"Her er bokstaven: {alphabet[randomNumber]}");
                //Console.WriteLine("riktig svar er: "+ correctAnswer);
                counter++;                
                string userInput = Console.ReadLine().ToUpper();
                
                if ( userInput == correctAnswer)
                {
                    Console.WriteLine("RIKTIG");
                    score++;
                    rightCounter++;
                    Console.WriteLine($"Your score is: {score}");
                    Console.WriteLine("End:-----------------------------------------");
                }
                else if(userInput == "STOP") 
                    { Console.WriteLine("Goodbye, thanks for playing."); break; }

                else if (counter == 10) 
                    { Console.WriteLine($"Game is finished. You got {rightCounter} right, and {wrongCounter} wrong. Your score is {score}."); break; }

                else 
                { 
                    Console.WriteLine($"{userInput} ER FEIL");
                    score--; 
                    wrongCounter++;
                    Console.WriteLine($"Your score is: {score}");
                    Console.WriteLine("End:-----------------------------------------");
                }

            }
            


        }
    }
}