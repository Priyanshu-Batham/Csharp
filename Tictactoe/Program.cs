class Tictactoe
{
    char[,] board;
    char human;
    char bot;

    //default constructor
    Tictactoe()
    {
        human = 'X';
        bot = 'O';

        board = new char[3, 3];
        for(int i = 0; i<3; i++)
        {
            for(int j = 0; j< 3; j++)
            {
                board[i, j] = '_';
            }
        }
    }

    //render board
    void render()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{board[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    //MINIMAX ALGORITHM
    int minimax(bool isBotMaxing)
    {
        //base case i.e: reaching the terminal state
        int result = checkResult();
        if (result != 2) return result;

        //Human's Turn
        if (!isBotMaxing)
        {
            int mini  = int.MaxValue;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == '_')
                    {
                        board[i, j] = human; //trying this move
                        int score = minimax(true); //calculating score
                        mini = Math.Min(mini, score);
                        board[i, j] = '_'; //reverting the tried move
                    }
                }
            }
            return mini;
        }
        else
        {
            int maxi = int.MinValue;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == '_')
                    {
                        board[i, j] = bot; //trying this move
                        int score = minimax(false); //calculating score
                        maxi = Math.Max(maxi, score);
                        board[i, j] = '_'; //reverting the tried move
                    }
                }
            }
            return maxi;
        }
    }


    //Function to start the Game!
    void play()
    {
        render();
        while (true) //game loop
        {
            //take human input and make the move
            humanPlaysMove();
            Console.WriteLine("YOU:");
            render();
            if(checkResult() == 0)
            {
                Console.WriteLine("Match DRAW"); //we don't check if human wins coz thats impossible
                break;
            }



            //ai calculates best move
            int bestScore = -999;
            int botRowMove = 0, botColMove = 0;  //these values will always get updated below so don't worry for 0, 0
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(board[i, j] == '_')
                    {
                        board[i, j] = bot; //trying this move
                        int score = minimax(false); //calculating score
                        if(score > bestScore)
                        {
                            bestScore = score; //updating best score
                            botRowMove = i;
                            botColMove = j;

                        }
                        board[i, j] = '_'; //reverting the tried move
                    }
                }
            }


            //ai makes the move
            board[botRowMove, botColMove] = bot;
            Console.WriteLine("BOT:");
            render();
            Console.WriteLine("----------------------------------");
            if(checkResult() == 1)
            {
                Console.WriteLine("YOU LOST");
                break;
            }
        }
    }



    //----------------HELPER FUNCTIONS---------------->>>
    void humanPlaysMove()
    {
        while (true)
        {
            Console.Write("Enter the Row no (0 - 2): ");
            int row = int.Parse(Console.ReadLine()!);
            Console.Write("Enter the Column no (0 - 2): ");
            int col = int.Parse(Console.ReadLine()!);

            if(row < 0 || col < 0 || row > 2 || col > 2 || board[row, col] != '_')
            {
                Console.WriteLine("Enter a valid input");
            }
            else
            {
                board[row, col] = human;
                break;
            }
        }
    }

    /*
     * Checks result
     * returns
     *  -1: Human wins
     *  0 : Draw
     *  +1: Bot wins
     *  +2: Not a terminal gameState
     */
    int checkResult()
    {
        //if any player made a Three-in-a-row : 1 or -1
        //TOP
        if ((board[0, 0] == board[0, 1]) && (board[0, 1] == board[0, 2]) && (board[0, 0] != '_'))
        {
            if (board[0, 0] == human) return -1;
            else return 1;
        }
        //RIGHT
        else if((board[0, 2] == board[1, 2]) && (board[1, 2] == board[2, 2]) && (board[0, 2] != '_'))
        {
            if (board[0, 2] == human) return -1;
            else return 1;
        }
        //BOTTOM
        else if((board[2, 0] == board[2, 1]) && (board[2, 1] == board[2, 2]) && (board[2, 0] != '_'))
        {
            if (board[2, 0] == human) return -1;
            else return 1;
        }
        //LEFT
        else if((board[0, 0] == board[1, 0]) && (board[1, 0] == board[2, 0]) && (board[0, 0] != '_'))
        {
            if (board[2, 0] == human) return -1;
            else return 1;
        }
        //L->R DIAGONAL
        else if((board[0, 0] == board[1, 1]) && (board[1, 1] == board[2, 2]) && (board[0, 0] != '_'))
        {
            if (board[0, 0] == human) return -1;
            else return 1;
        }  
        //R->L DIAGONAL
        else if((board[0, 2] == board[1, 1]) && (board[1, 1] == board[2, 0]) && (board[0, 2] != '_'))
        {
            if (board[0, 2] == human) return -1;
            else return 1;
        }
        //MIDDLE HORIZONTAL
        else if((board[1, 0] == board[1, 1]) && (board[1, 1] == board[1, 2]) && (board[1, 0] != '_'))
        {
            if (board[1, 0] == human) return -1;
            else return 1;
        }
        //MIDDLE VERTICAL
        else if((board[0, 1] == board[1, 1]) && (board[1, 1] == board[2, 1]) && (board[0, 1] != '_'))
        {
            if (board[0, 1] == human) return -1;
            else return 1;
        }


        //is the game still running : 2
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == '_') return 2;
            }
        }

        //is the game draw (no more space in board) : 0
        return 0;
    }

    //---------------PSVM-------------->>>>
    public static void Main()
    {
        Console.WriteLine("--------WELCOME TO THE UNBEATABLE TICTACTOE--------");
        Console.WriteLine("You will be playing as X and the bot is O...GOODLUCK");
        Tictactoe game = new Tictactoe();
        game.play();
    }
}