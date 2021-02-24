using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject");
            string answer = Console.ReadLine().ToLower();

            switch (answer)
            {
                case "math":
                    Console.WriteLine($"You have entered the subject of {answer}.  Computation are fun.");
                    break;
                case "english":
                    Console.WriteLine($"You have entered the subject of {answer}. English literature is my favorite.");
                    break;
                case "art":
                    Console.WriteLine($"You have entered the subject of {answer}.  Creative artist run in our family.");
                    break;
                case "history":
                    Console.WriteLine($"You have entered the subject of {answer}.  You must know history to appreciate the future.");
                    break;
                case "science":
                    Console.WriteLine($"You have entered the subject of {answer}.  Science projects are awesome.");
                    break;
                default:
                    Console.WriteLine($"You have entered the subject of {answer}.  This not one of my 5 favorites.");
                     break;
            }
        }
    }
}
