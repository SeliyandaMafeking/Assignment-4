 using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10,6);
            _boardRenderer.Render();

        }
        public static char[,] board = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };

        public void Run()
        {

            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TO
          
           
            int playerX = 0;
            int playerO = 0;


            

            while (true)
            {
                Console.SetCursorPosition(2, 19);

                Console.Write("Player X");

                Console.SetCursorPosition(2, 20);

                Console.Write("Please Enter Row: ");
                var row = Console.ReadLine();

                Console.SetCursorPosition(2, 22);


                Console.Write("Please Enter Column: ");
                var column = Console.ReadLine();


                // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
                _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);

                Console.SetCursorPosition(2, 19);

                Console.Write("Player O");

                Console.SetCursorPosition(2, 20);

                Console.Write("Please Enter Row: ");
                row = Console.ReadLine();

                Console.SetCursorPosition(2, 22);


                Console.Write("Please Enter Column: ");
                column = Console.ReadLine();

                _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O, true);

                // check if move is valid

                if(board[int.Parse(row), int.Parse(column)] == ' ')
                {
                    _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);
                    board[int.Parse(row), int.Parse(column)] = 'X';
                    playerX += 1;
                }
                else
                {
                    Console.WriteLine("Try Again");
                }


                if (board[0, 0] == 'X' && board[0,1] == 'X' && board[0,2] == 'X')
                {
                    Console.WriteLine("Player X wins!");
                }
                else if (board[1,0] == 'X' && board[1,1] == 'X' && board[1,2] == 'X')
                {
                    Console.WriteLine("Player X wins!");
                }
                else if (board[2,0] == 'X' && board[2,1] == 'X' && board[2,2] == 'X')
                {
                    Console.WriteLine("Player X wins!");
                }
                else if (board[0,0] == 'X' && board[1,0] == 'X' && board[2,0] == 'X')
                {
                    Console.WriteLine("Player X wins!");
                }
               else  if (board[0, 1] == 'X' && board[1, 1] == 'X' && board[2, 1] == 'X')
                {
                    Console.WriteLine("Player X wins!");
                }
                else if (board[0, 2] == 'X' && board[1, 2] == 'X' && board[2, 2] == 'X')
                {
                    Console.WriteLine("Player X wins!");
                }
                else if (board[0, 0] == 'X' && board[1, 1] == 'X' && board[2, 2] == 'X')
                {
                    Console.WriteLine("Player X wins!");
                }
               else  if (board[0, 2] == 'X' && board[1, 1] == 'X' && board[2, 0] == 'X')
                {
                    Console.WriteLine("Player X wins!");
                }

                //check if move is valid

                if (board[int.Parse(row), int.Parse(column)] == ' ')
                {
                    _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);
                    board[int.Parse(row), int.Parse(column)] = 'O';
                    playerO += 1;
                }
                else
                {
                    Console.WriteLine("Try Again");
                }

                if (board[0, 0] == 'O' && board[0, 1] == 'O' && board[0, 2] == 'O')
                {
                    Console.WriteLine("Player O wins!");
                }
                else if (board[1, 0] == 'O' && board[1, 1] == 'O' && board[1, 2] == 'O')
                {
                    Console.WriteLine("Player O wins!");
                }
                else if (board[2, 0] == 'O' && board[2, 1] == 'O' && board[2, 2] == 'O')
                {
                    Console.WriteLine("Player O wins!");
                }
                else if (board[0, 0] == 'O' && board[1, 0] == 'O' && board[2, 0] == 'O')
                {
                    Console.WriteLine("Player O wins!");
                }
                else if (board[0, 1] == 'O' && board[1, 1] == 'O' && board[2, 1] == 'O')
                {
                    Console.WriteLine("Player O wins!");
                }
                else if (board[0, 2] == 'O' && board[1, 2] == 'O' && board[2, 2] == 'O')
                {
                    Console.WriteLine("Player O wins!");
                }
                else if (board[0, 0] == 'O' && board[1, 1] == 'O' && board[2, 2] == 'O')
                {
                    Console.WriteLine("Player O wins!");
                }
                else if (board[0, 2] == 'O' && board[1, 1] == 'O' && board[2, 0] == 'O')
                {
                    Console.WriteLine("Player O wins!");
                }

                //check if it's a draw


            }
        }

    }
}
