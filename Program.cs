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
                Random rnd = new Random();
                int compChoice = rnd.Next(3);


                if (Console.ReadKey().KeyChar == 'r')
                {
                     if (compChoice == 1)
                {
                Console.WriteLine($"Comp chose rock");
                Console.WriteLine($"YOU TIE!");

                } else if(compChoice == 2)
                {
                Console.WriteLine($"Comp chose paper");
                Console.WriteLine($"YOU LOSE!");
                } else 
                {
                Console.WriteLine($"Comp chose scissors");
                Console.WriteLine($"YOU WIN!");
                }
                } else if (Console.ReadKey().KeyChar == 'p')
                {
                     if (compChoice == 1)
                {
                Console.WriteLine($"Comp chose rock");
                Console.WriteLine($"YOU WIN!");

                } else if(compChoice == 2)
                {
                Console.WriteLine($"Comp chose paper");
                Console.WriteLine($"YOU TIE!");
                } else 
                {
                Console.WriteLine($"Comp chose scissors");
                Console.WriteLine($"YOU LOSE! ");
                }
                } else if (Console.ReadKey().KeyChar == 's')
                {
                if (compChoice == 1)
                {
                Console.WriteLine($"Comp chose rock");
                Console.WriteLine($"YOU LOSE!");
                } else if(compChoice == 2)
                {
                Console.WriteLine($"Comp chose paper");
                Console.WriteLine($"YOU WIN!");
                } else 
                {
                Console.WriteLine($"Comp chose scissors");
                Console.WriteLine($"YOU TIE!");
                }
                }


                // string playerChoice = Console.ReadLine().ToLower().Trim();
                // if (compChoice == 1)
                // {
                // Console.WriteLine($"Comp chose rock");
                // } else if(compChoice == 2)
                // {
                // Console.WriteLine($"Comp chose paper");

                // } else 
                // {
                // Console.WriteLine($"Comp chose scissors");

                // }
                // Console.WriteLine($"You chose {playerChoice}");

            }

        }
    }
}
