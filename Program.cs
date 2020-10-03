using System;

namespace SnakeAndLadderProblem
{
    class Program
    {
        public const int START = 0;
        public const int END = 100;
        static void Main(string[] args)
        {

            // Random object dice to know dice input
            Random dice = new Random();
            // Random object option to know what option is encountered
            Random option = new Random();

            Console.WriteLine("=================================");
            Console.WriteLine("Welcome to Snakes and Ladder Game");
            Console.WriteLine("=================================");

            Console.WriteLine("Enter the Game Mode===>");
            Console.WriteLine("1. Single Player Mode");
            Console.WriteLine("2. Dual Player Mode");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int positionPlayer = START;
                    int moves = 0;

                    Console.WriteLine("Current Position Of Player-1 is {0}", positionPlayer);
                    Console.WriteLine("Current Moves Number={0}", moves);

                    while (positionPlayer < 100)
                    {

                        int diceInput = dice.Next(1, 7);
                        Console.WriteLine("Your Dice Score={0}", diceInput);
                        positionPlayer += diceInput;
                        moves++;
                        int opPlay = option.Next(0, 3);
                        switch (opPlay)
                        {
                            case 0:
                                Console.WriteLine("Your Option is No Play.");
                                break;
                            case 1:
                                Console.WriteLine("Your Option is Ladder.");
                                positionPlayer += diceInput;
                                break;
                            case 2:
                                Console.WriteLine("Your Option is Snakes.");
                                positionPlayer -= diceInput;
                                break;
                        }
                        if (positionPlayer < 0)
                        {
                            positionPlayer = START;
                        }
                        Console.WriteLine("Your Position={0}", positionPlayer);
                        Console.WriteLine("Your Moves={0}", moves);
                    }
                    break;

            }
        }
    }
}
