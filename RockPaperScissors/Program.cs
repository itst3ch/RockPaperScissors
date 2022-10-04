using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
        start:
            Console.Title = "Main Menu";
            Console.WriteLine("Type the number of which option you would like: ");
            Console.WriteLine("1. Play");
            Console.WriteLine("2. Exit");
            string choice = Convert.ToString(Console.ReadLine());
            if(choice == "1")
            {
                Console.Clear();
                Game();
            }
            else if (choice == "2")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                goto start;
            }
        }

        public static void Game()
        {
        Game:
            Console.Title = "Rock Paper Scissors";
            Console.Write("Please input rock/paper/scissors/exit: ");
            string input = Convert.ToString(Console.ReadLine());
            input = input.ToLower();
            //determine computer choice
            Random rps = new Random();
            int computer = rps.Next(1, 4);
            bool rock = false;
            bool paper = false;
            bool scissors = false;
            string compchoice = "a";
            if (computer == 1)
            {
                rock = true;
                compchoice = "rock";
            }
            else if (computer == 2)
            {
                paper = true;
                compchoice = "paper";
            }
            else if (computer == 3)
            {
                scissors = true;
                compchoice = "scissors";
            }

            //determine user input
            if (input == "rock")
            {
                if (scissors)
                {
                    Console.WriteLine("The computer chose scissors, you win! Play again? [Y/N]");
                    PlayAgain();
                }
                else if (compchoice == input)
                {
                    Console.WriteLine("It's a tie! Play again? [Y/N]");
                    PlayAgain();
                }
                else
                {
                    Console.WriteLine("The computer chose " + compchoice + ", you lose. Play again? [Y/N]");
                    PlayAgain();
                }
            }
            else if (input == "paper")
            {
                if (rock)
                {
                    Console.WriteLine("The computer chose rock, you win! Play again? [Y/N]");
                    PlayAgain();
                }
                else if (compchoice == input)
                {
                    Console.WriteLine("It's a tie! Play again? [Y/N]");
                    PlayAgain();
                }
                else
                {
                    Console.WriteLine("The computer chose " + compchoice + ", you lose. Play again? [Y/N]");
                    PlayAgain();
                }
            }
            else if (input == "scissors")
            {
                if (paper)
                {
                    Console.WriteLine("The computer chose paper, you win! Play again? [Y/N]");
                    PlayAgain();
                }
                else if (compchoice == input)
                {
                    Console.WriteLine("It's a tie! Play again? [Y/N]");
                    PlayAgain();
                }
                else
                {
                    Console.WriteLine("The computer chose " + compchoice + ", you lose. Play again? [Y/N]");
                    PlayAgain();
                }
            }
            else if (input == "exit")
            {
                Console.Clear();
                Menu();
            }
            else
            {
                Console.WriteLine("Invalid response.");
                goto Game;
            }
        }

        public static void PlayAgain()
        {
        test:
            string again = Convert.ToString(Console.ReadLine());
            again = again.ToUpper();
            if (again == "Y")
            {
                Console.Clear();
                Game();
            }
            else if (again == "N")
            {
                Console.Clear();
                Menu();
            }
            else
            {
                Console.WriteLine("Invalid response");
                Console.WriteLine("Play again? [Y/N]");
                goto test;
            }
        }
    }
}
