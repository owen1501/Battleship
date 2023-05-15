using System;
using Internal;

class MainClass
{
    static void Main(string[] args)
    {

        char[,] actualBoard = new char[10, 10];//boat memo
                                               //ry
                                               //can have the numbers changhed to enlarge board you just need add to coletter
        char[,] board = new char[10, 10]; //display board
                                          //can have the numbers changhed to enlarge board you just need add to coletter

        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                board[i, j] = '-'; //adding ambience
                actualBoard[i, j] = '-'; // adding ambience
            }
        }




        //PLACE SHIPS
        Random random = new Random(); //RANDOM NUMBER GENNERATOR
        Random randy = new Random();
        Random randomness = new Random();
        Random rand = new Random();
        int wow = random.Next(0, 3); //SHIP TYPE
        Console.WriteLine(wow);





        //BATTLESHIP
        int ship1x = random.Next(0, 10);
        int ship1y = random.Next(0, 10);

        actualBoard[ship1x, ship1y] = 'X';   //MAKE IT WIDER
        actualBoard[ship1x + 1, ship1y] = 'X';
        actualBoard[ship1x + 2, ship1y] = 'X';




        //AIRDRAFT CARRIER
        int ship2x = rand.Next(0, 10);
        int ship2y = rand.Next(0, 10);

        actualBoard[ship2x, ship2y] = 'X';    //MAKE IT WIDER
        actualBoard[ship2x, ship2y + 1] = 'X';
        actualBoard[ship2x, ship2y + 2] = 'X';
        actualBoard[ship2x, ship2y + 3] = 'X';
        actualBoard[ship2x, ship2y + 4] = 'X';



        //DESTROYER
        int ship3x = randy.Next(0, 10);
        int ship3y = randy.Next(0, 10);

        actualBoard[ship3x, ship3y] = 'X';    //MAKE IT WIDER
        actualBoard[ship3x, ship3y + 1] = 'X';

        actualBoard[ship3x, ship3y + 2] = 'X';
        actualBoard[ship3x, ship3y + 3] = 'X';


        //PATROL BOAT
        int ship4x = randomness.Next(0, 10);
        int ship4y = randomness.Next(0, 10);

        actualBoard[ship4x, ship4y] = 'X';    //MAKE IT WIDER
        actualBoard[ship4x, ship4y + 1] = 'X';



        int shipPieces = 14; //How many x's until game ends
        int shipHits = 0;
        int guesses = 0;

        bool gameOver = false; //MAKE GAME REPEAT

        while (gameOver != true)
        {
            try //FAILSAFE INCASE DOESNT WORK
            {
                drawBoard(board);
                Console.Write("Enter a letter: \n");
                string colLetter = Console.ReadLine();
                colLetter = colLetter.ToUpper();
                int row = 0;

                Console.Write("Enter a number: \n");
                string rowInput = Console.ReadLine();
                int col = Int32.Parse(rowInput) - 1;



                //MAKE ROWS 
                if (colLetter == "A")
                {
                    row = 0;
                }
                else if (colLetter == "B")
                {
                    row = 1;
                }
                else if (colLetter == "C")
                {
                    row = 2;
                }
                else if (colLetter == "D")
                {
                    row = 3;
                }
                else if (colLetter == "E")
                {
                    row = 4;
                }
                else if (colLetter == "F")
                {
                    row = 5;
                }
                else if (colLetter == "G")
                {
                    row = 6;
                }
                else if (colLetter == "H")
                {
                    row = 7;
                }
                else if (colLetter == "I")
                {
                    row = 8;
                }
                else if (colLetter == "J")
                {
                    row = 9;
                }

                string playAgain = "1";
                if (board[row, col] == '-') //check if applicable for move
                {
                    guesses++;
                    if (actualBoard[row, col] == 'X')
                    {
                        board[row, col] = 'X';
                        Console.WriteLine("Hit!");
                        shipHits++;
                        if (shipHits == shipPieces) // HOW MANY HITS AND SHIPS once 14 hits all 14 points of boats are sunk
                        {
                            Console.Write("would you like to play again? 1 for yes and 2 for no"); //PLAY AGAIN CODE NEEDS WORK
                            playAgain = Console.ReadLine();


                            if (playAgain == "1")
                            {

                                drawBoard(board);

                                for (int i = 0; i < board.GetLength(0); i++)
                                {
                                    for (int x = 0; x < board.GetLength(1); x++)
                                    {
                                        board[i, x] = '-'; //adding ambience
                                        actualBoard[i, x] = '-'; // adding ambience
                                    }
                                }
                                //PLACE SHIPS
                                Random brandon = new Random(); //RANDOM NUMBER GENNERATOR
                                Random brandy = new Random();
                                Random brandedclothing = new Random();
                                Random sultanaBran = new Random();
                                int kachow = random.Next(0, 3); //SHIP TYPE
                                Console.WriteLine(kachow);





                                //BATTLESHIP
                                int shipIx = brandon.Next(0, 10);
                                int shipIy = brandon.Next(0, 10);

                                actualBoard[shipIx, shipIy] = 'X';   //MAKE IT WIDER
                                actualBoard[shipIx + 1, shipIy] = 'X';
                                actualBoard[shipIx + 2, shipIy] = 'X';




                                //AIRDRAFT CARRIER
                                int shipIIx = brandy.Next(0, 10);
                                int shipIIy = brandy.Next(0, 10);

                                actualBoard[shipIIx, shipIIy] = 'X';    //MAKE IT WIDER
                                actualBoard[shipIIx, shipIIy + 1] = 'X';
                                actualBoard[shipIIx, shipIIy + 2] = 'X';
                                actualBoard[shipIIx, shipIIy + 3] = 'X';
                                actualBoard[shipIIx, shipIIy + 4] = 'X';



                                //DESTROYER
                                int shipIIIx = brandedclothing.Next(0, 10);
                                int shipIIIy = brandedclothing.Next(0, 10);

                                actualBoard[shipIIIx, shipIIIy] = 'X';    //MAKE IT WIDER
                                actualBoard[shipIIIx, shipIIIy + 1] = 'X';

                                actualBoard[shipIIIx, shipIIIy + 2] = 'X';
                                actualBoard[shipIIIx, shipIIIy + 3] = 'X';


                                //PATROL BOAT
                                int shipIVx = sultanaBran.Next(0, 10);
                                int shipIVy = sultanaBran.Next(0, 10);

                                actualBoard[shipIVx, shipIVy] = 'X';    //MAKE IT WIDER
                                actualBoard[shipIVx, shipIVy + 1] = 'X';



                            }

                        }
                        else if (playAgain == "2")
                        {
                            gameOver = true;
                        }


                    }
                    else
                    {
                        board[row, col] = 'O';
                        Console.WriteLine("Miss!");
                    }
                }
            }
            catch //INCASE OF WRONG INPUT
            {
                Console.WriteLine("You just wasted a 2.5 Million Dollar Payload, That could have helped 166,666 starving African children, stay within the grid!");
            }

        }


        //end game

        drawBoard(board);
        Console.WriteLine($"You won with {guesses} guesses");


    }

    public static void drawBoard(char[,] arr)
    {
        Console.Clear();
        int InitialiseBoard = 65;

        Console.Write(" \t");
        for (int i = 1; i < arr.GetLength(1) + 1; i++)
        {
            Console.Write($"{i}\t"); // SPACES OUT
        }
        Console.WriteLine("\n"); //so looks good creates new line

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write($"{(char)InitialiseBoard}\t");
            for (int x = 0; x < arr.GetLength(1); x++)
            {
                Console.Write($"{arr[i, x]}\t"); // INITIALISES SIMILAR TOO gameBoard[i,j] in tic tac toe
            }
            Console.WriteLine();
            InitialiseBoard++;
        }
    }
}

