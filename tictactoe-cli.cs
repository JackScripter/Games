using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static string WrongMove() // When the variable is already X or O
        {
            string error = "Invalid move !";
            return error;
        }
        static void CheckWin(string C1, string C2, string C3, string C4, string C5, string C6, string C7, string C8, string C9, int P1S, int P2S, string playerOne, string playerTwo,bool playerOneTurn) // Check win condition
        {
            if((C1 == "X" && C2 == "X" && C3 == "X") || (C1 == "X" && C4 == "X" && C7 == "X") || (C1 == "X" && C5 == "X" && C9 == "X") || (C2 == "X" && C5 == "X" && C8 == "X") || (C3 == "X" && C6 == "X" && C9 == "X") || (C4 == "X" && C5 == "X" && C6 == "X") || (C7 == "X" && C8 == "X" && C9 == "X") || (C3 == "X" && C5 == "X" && C7 == "X")) // Player one win condition
            {
                P1S++;
                Console.WriteLine("The winner is {0}", playerOne);
                Console.ReadKey();
                NewGame(playerOne,playerTwo,P1S,P2S,playerOneTurn);
            } else if ((C1 == "O" && C2 == "O" && C3 == "O") || (C1 == "O" && C4 == "O" && C7 == "O") || (C1 == "O" && C5 == "O" && C9 == "O") || (C2 == "O" && C5 == "O" && C8 == "O") || (C3 == "O" && C6 == "O" && C9 == "O") || (C4 == "O" && C5 == "O" && C6 == "O") || (C7 == "O" && C8 == "O" && C9 == "O") || (C3 == "O" && C5 == "O" && C7 == "O")) // Player two win condition
            {
                P2S++;
                Console.WriteLine("The winner is {0}", playerTwo);
                Console.ReadKey();
                NewGame(playerOne, playerTwo, P1S, P2S,playerOneTurn);
            }
        }
        static void PlayerOneTurn(string C1, string C2, string C3, string C4, string C5, string C6, string C7, string C8, string C9, int P1S, int P2S, bool playerOneTurn, string playerOne, string playerTwo) // Player one move & actions
        {
            Console.Write("Case: "); int move = int.Parse(Console.ReadLine());
            if (move > 0 && move < 10)
            {
                switch (move)
                {
                    case 1: if (C1 == "1") { C1 = "X"; playerOneTurn = false; } else { Console.WriteLine(WrongMove()); Console.ReadKey(); } break;
                    case 2: if (C2 == "2") { C2 = "X"; playerOneTurn = false; } else { Console.WriteLine(WrongMove()); Console.ReadKey(); } break;
                    case 3: if (C3 == "3") { C3 = "X"; playerOneTurn = false; } else { Console.WriteLine(WrongMove()); Console.ReadKey(); } break;
                    case 4: if (C4 == "4") { C4 = "X"; playerOneTurn = false; } else { Console.WriteLine(WrongMove()); Console.ReadKey(); } break;
                    case 5: if (C5 == "5") { C5 = "X"; playerOneTurn = false; } else { Console.WriteLine(WrongMove()); Console.ReadKey(); } break;
                    case 6: if (C6 == "6") { C6 = "X"; playerOneTurn = false; } else { Console.WriteLine(WrongMove()); Console.ReadKey(); } break;
                    case 7: if (C7 == "7") { C7 = "X"; playerOneTurn = false; } else { Console.WriteLine(WrongMove()); Console.ReadKey(); } break;
                    case 8: if (C8 == "8") { C8 = "X"; playerOneTurn = false; } else { Console.WriteLine(WrongMove()); Console.ReadKey(); } break;
                    case 9: if (C9 == "9") { C9 = "X"; playerOneTurn = false; } else { Console.WriteLine(WrongMove()); Console.ReadKey(); } break;
                }
                CheckWin(C1, C2, C3, C4, C5, C6, C7, C8, C9, P1S, P2S, playerOne, playerTwo,playerOneTurn);
                Mainboard(C1, C2, C3, C4, C5, C6, C7, C8, C9, P1S, P2S, playerOneTurn, playerOne, playerTwo);
            }

        }
        static void PlayerTwoTurn(string C1, string C2, string C3, string C4, string C5, string C6, string C7, string C8, string C9, int P1S, int P2S, bool playerOneTurn, string playerOne, string playerTwo) // Player two move & actions
        {
            Console.Write("Case: "); int move = int.Parse(Console.ReadLine());
            if (move > 0 && move < 10)
            {
                switch (move)
                {
                    case 1: if (C1 == "1") { C1 = "O"; playerOneTurn = true; } else { Console.WriteLine(WrongMove()); Console.ReadKey(); } break;
                    case 2: if (C2 == "2") { C2 = "O"; playerOneTurn = true; } else { Console.WriteLine(WrongMove()); Console.ReadKey(); } break;
                    case 3: if (C3 == "3") { C3 = "O"; playerOneTurn = true; } else { Console.WriteLine(WrongMove()); Console.ReadKey(); } break;
                    case 4: if (C4 == "4") { C4 = "O"; playerOneTurn = true; } else { Console.WriteLine(WrongMove()); Console.ReadKey(); } break;
                    case 5: if (C5 == "5") { C5 = "O"; playerOneTurn = true; } else { Console.WriteLine(WrongMove()); Console.ReadKey(); } break;
                    case 6: if (C6 == "6") { C6 = "O"; playerOneTurn = true; } else { Console.WriteLine(WrongMove()); Console.ReadKey(); } break;
                    case 7: if (C7 == "7") { C7 = "O"; playerOneTurn = true; } else { Console.WriteLine(WrongMove()); Console.ReadKey(); } break;
                    case 8: if (C8 == "8") { C8 = "O"; playerOneTurn = true; } else { Console.WriteLine(WrongMove()); Console.ReadKey(); } break;
                    case 9: if (C9 == "9") { C9 = "O"; playerOneTurn = true; } else { Console.WriteLine(WrongMove()); Console.ReadKey(); } break;
                }
                CheckWin(C1, C2, C3, C4, C5, C6, C7, C8, C9, P1S, P2S, playerOne, playerTwo,playerOneTurn);
                Mainboard(C1, C2, C3, C4, C5, C6, C7, C8, C9, P1S, P2S, playerOneTurn, playerOne, playerTwo);
            }

        }
        static void Mainboard(string C1, string C2, string C3, string C4, string C5, string C6, string C7, string C8, string C9,int P1S,int P2S,bool playerOneTurn,string playerOne,string playerTwo)
        {
            Console.Clear();
            // Main board
            Console.WriteLine("{0} (X): {1}    {2} (O): {3}", playerOne, P1S, playerTwo, P2S);
            Console.WriteLine("\n    {0} | {1} | {2} \n   ---|---|---\n    {3} | {4} | {5}\n   ---|---|---\n    {6} | {7} | {8}\n\n", C1, C2, C3, C4, C5, C6, C7, C8, C9);

            // Ask for move
            if (playerOneTurn)
            {
                Console.WriteLine("{0}'s turn !", playerOne);
                PlayerOneTurn(C1, C2, C3, C4, C5, C6, C7, C8, C9, P1S, P2S, playerOneTurn, playerOne, playerTwo);
            } else
            {
                Console.WriteLine("{0}'s turn !", playerTwo);
                PlayerTwoTurn(C1, C2, C3, C4, C5, C6, C7, C8, C9, P1S, P2S, playerOneTurn, playerOne, playerTwo);
            }

        }
        static void NewGame(string playerOne,string playerTwo,int P1S,int P2S, bool playerOneTurn)
        {
            string C1 = "1"; string C2 = "2"; string C3 = "3"; string C4 = "4"; string C5 = "5"; string C6 = "6"; string C7 = "7"; string C8 = "8"; string C9 = "9";

            Mainboard(C1, C2, C3, C4, C5, C6, C7, C8, C9, P1S, P2S, playerOneTurn, playerOne, playerTwo);
            if (playerOneTurn) playerOneTurn = false; else playerOneTurn = true; // Alterne le premier tour
        }

        static void Main(string[] args)
        {
            // Initialize
            int P1S = 0;int P2S = 0;
            bool playerOneTurn = true; // true = player 1's turn , false = player 2's turn
            // Ask player name
            Console.Write("Player 1: ");string playerOne = Console.ReadLine();
            Console.Write("Player 2: ");string playerTwo = Console.ReadLine();
            NewGame(playerOne, playerTwo, P1S, P2S,playerOneTurn);

            Console.ReadKey();
        }
    }
}
