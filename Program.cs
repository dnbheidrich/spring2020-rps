using System;

namespace rps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hello Player!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            bool running = true;
            while (running)
            {
                Console.WriteLine("Do you want to play a game? (y/n)");
                if (Console.ReadKey().KeyChar == 'n')
                {
                    running = false;
                    break;
                }
                Console.Clear();
                Console.WriteLine("Rock, Paper, or Scissors?");
                string playerChoice = Console.ReadLine().ToLower().Trim();
                Random rnd = new Random();
                int compChoice = rnd.Next(3);

                // ????????
            }

        }
    }
}
