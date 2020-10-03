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

            //Choice for Single Player Mode Or Multiple Player Mode
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int positionPlayer = START;
                    int moves = 0;

                    Console.WriteLine("Current Position Of Player-1 is {0}", positionPlayer);
                    Console.WriteLine("Current Moves Number={0}", moves);

                    //Game End Condition
                    while (positionPlayer < 100)
                    {

                        // Rolling the dice
                        int diceInput = dice.Next(1, 7);
                        moves++;
                        Console.WriteLine("Your Dice Score={0}", diceInput);
                        // Ensuring the exact winning Condition
                        if (positionPlayer + diceInput > 100)
                        {
                            continue;
                        }
                        else
                        {
                            positionPlayer += diceInput;
                        }
                        
                        int optionPlay = option.Next(0, 3);
                        switch (optionPlay)
                        {
                            case 0:
                                Console.WriteLine("Your Option is No Play.");
                                break;
                            case 1:
                                Console.WriteLine("Your Option is Ladder.");
                                if (positionPlayer + diceInput > 100)
                                {
                                    continue;
                                }
                                else
                                {
                                    positionPlayer += diceInput;
                                }

                                break;
                            case 2:
                                Console.WriteLine("Your Option is Snakes.");
                                positionPlayer -= diceInput;
                                break;
                        }
                        // Ensuring non-negative posiitons which are not possible in real-world
                        if (positionPlayer < 0)
                        {
                            positionPlayer = START;
                        }
                        //Reporting the Position after every move and number of moves
                        Console.WriteLine("Your Position={0}", positionPlayer);
                        Console.WriteLine("Your Moves={0}", moves);
                    }
                    break;

                case 2:
                    int positionFirstPlayer = START;
                    int positionSecondPlayer = START;
                    int turnPlayer = 1;
                    int movesFirstPlayer = 0;
                    int movesSecondPlayer = 0;

                    //Loop to ensure either wining condition
                    while (positionFirstPlayer != END && positionSecondPlayer != END)
                    {
                        if (turnPlayer == 1)
                        {
                            
                            int diceInput = dice.Next(1, 7);
                            movesFirstPlayer++;
                            Console.WriteLine("Your Dice Score={0}", diceInput);
                            if (positionFirstPlayer + diceInput > END)
                            {
                                continue;
                            }
                            else
                            {
                                positionFirstPlayer += diceInput;
                            }

                            int optionPlay = option.Next(0, 3);
                            switch (optionPlay)
                            {
                                case 0:
                                    Console.WriteLine("Your Option is No Play.");
                                    break;
                                case 1:
                                    Console.WriteLine("Your Option is Ladder.");
                                    if (positionFirstPlayer + diceInput > END)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        positionFirstPlayer += diceInput;
                                    }
                                    turnPlayer = 1;
                                    break;
                                case 2:
                                    Console.WriteLine("Your Option is Snakes.");
                                    positionFirstPlayer -= diceInput;
                                    break;
                            }
                            if (positionFirstPlayer < 0)
                            {
                                positionFirstPlayer = START;
                            }
                            Console.WriteLine("First Player Position={0}", positionFirstPlayer);
                            Console.WriteLine("First Player Moves={0}", movesFirstPlayer);
                            turnPlayer = 2;
                        }

                        else if (turnPlayer == 2)
                        {
                            int diceInput = dice.Next(1, 7);
                            movesSecondPlayer++;
                            Console.WriteLine("Your Dice Score={0}", diceInput);
                            if (positionSecondPlayer + diceInput > END)
                            {
                                continue;
                            }
                            else
                            {
                                positionSecondPlayer += diceInput;
                            }

                            int opPlay = option.Next(0, 3);
                            switch (opPlay)
                            {
                                case 0:
                                    Console.WriteLine("Your Option is No Play.");
                                    break;
                                case 1:
                                    Console.WriteLine("Your Option is Ladder.");
                                    if (positionSecondPlayer + diceInput > END)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        positionSecondPlayer += diceInput;
                                    }
                                    turnPlayer = 2;
                                    break;
                                case 2:
                                    Console.WriteLine("Your Option is Snakes.");
                                    positionSecondPlayer -= diceInput;
                                    break;
                            }
                            if (positionSecondPlayer < 0)
                            {
                                positionSecondPlayer = START;
                            }
                            Console.WriteLine("Second Player Position={0}", positionSecondPlayer);
                            Console.WriteLine("Second Player Moves={0}", movesSecondPlayer);
                            turnPlayer = 1;
                        }
                    }
                    if (positionFirstPlayer == END)
                    {
                        Console.WriteLine("First Player Position={0}", positionFirstPlayer);
                        Console.WriteLine("Player-1 is Winner and total moves in game is {0}", movesFirstPlayer + movesSecondPlayer);
                    }

                    else if (positionSecondPlayer == END)
                    {
                        Console.WriteLine("Second Player Position={0}", positionSecondPlayer);
                        Console.WriteLine("Player-2 is Winner and total moves in game is {0}", movesFirstPlayer + movesSecondPlayer);
                    }

                    else
                    {
                        Console.WriteLine("Player-1={0}  ,  Player-2={1}", positionFirstPlayer, positionSecondPlayer);
                    }
                    break;

                default:
                    Console.WriteLine("Supports only two Modes!!!!!!!!!!");
                    break;



            }
        }
    }
}
