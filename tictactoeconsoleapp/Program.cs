using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoeconsoleapp
{
    class Program
    {
        //playfield
        static char[,] playField =
        {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'}
        };

        static int player1Wins = 0;
        static int player2Wins = 0;
        static int turns = 0;


        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;
           
            SetField();
            do
            {
                if (player == 2)
                {
                    player = 1;
                    WhichCharacter('O', input);
                }
                else if (player == 1)
                {
                    player = 2;
                    WhichCharacter('X', input);
                }
                SetField();
                char[] playCharacter = { 'X', 'O' };
                foreach (char c in playCharacter)
                {
                    if ((playField[0, 0].Equals(c)) && (playField[0, 1].Equals(c)) && (playField[0, 2].Equals(c)))
                    {
                        WhoWins(c, player1Wins, player2Wins);
                    }
                    else if ((playField[1, 0].Equals(c)) && (playField[1, 1].Equals(c)) && (playField[1, 2].Equals(c)))
                    {
                        WhoWins(c, player1Wins, player2Wins);
                    }
                    else if ((playField[2, 0].Equals(c)) && (playField[2, 1].Equals(c)) && (playField[2, 2].Equals(c)))
                    {
                        WhoWins(c, player1Wins, player2Wins);
                    }
                    else if ((playField[0, 1].Equals(c)) && (playField[1, 1].Equals(c)) && (playField[2, 1].Equals(c)))
                    {
                        WhoWins(c, player1Wins, player2Wins);
                    }
                    else if ((playField[0, 2].Equals(c)) && (playField[1, 1].Equals(c)) && (playField[2, 0].Equals(c)))
                    {
                        WhoWins(c, player1Wins, player2Wins);
                    }
                    else if ((playField[0, 0].Equals(c)) && (playField[1, 0].Equals(c)) && (playField[2, 0].Equals(c)))
                    {
                        WhoWins(c, player1Wins, player2Wins);
                    }
                    else if ((playField[0, 0].Equals(c)) && (playField[1, 1].Equals(c)) && (playField[2, 2].Equals(c)))
                    {
                        WhoWins(c, player1Wins, player2Wins);
                    }
                    else if ((playField[0, 1].Equals(c)) && (playField[1, 1].Equals(c)) && (playField[1, 2].Equals(c)))
                    {
                        WhoWins(c, player1Wins, player2Wins);
                    }
     
                }
                do
                {
                    Console.Write("\nPlayer{0}: Choose a spot\t", player);
                    try
                    {
                        input = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number !");
                    }
                    if ((input == 1) && (playField[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (playField[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (playField[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (playField[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (playField[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (playField[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (playField[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (playField[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (playField[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("Incorrect input! Choose another spot");
                        inputCorrect = false;
                    }

                } while (!inputCorrect);
            } while (true);
        }
        public static void ResetField()
        {
            char[,] playFieldStart =
        {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'}
        };


            playField = playFieldStart;
            SetField();
            turns = 0;
        }

        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("         |           |   ");
            Console.WriteLine("     {0}   |     {1}     |   {2}", playField[0,0], playField[0,1], playField[0,2]);
            Console.WriteLine("_________|___________|________");
            Console.WriteLine("         |           |   ");
            Console.WriteLine("     {0}   |     {1}     |   {2}", playField[1,0], playField[1,1], playField[1,2]);
            Console.WriteLine("_________|___________|________");
            Console.WriteLine("         |           |   ");
            Console.WriteLine("     {0}   |     {1}     |   {2}", playField[2,0], playField[2,1], playField[2,2]);
            Console.WriteLine("         |           |       ");
            turns++;

        }
        public static void PickSpot(int values, char sign)
        {
            switch (values)
            {
                case 1: playField[0, 0] = sign; break;
                case 2: playField[0, 1] = sign; break;
                case 3: playField[0, 2] = sign; break;
                case 4: playField[1, 0] = sign; break;
                case 5: playField[1, 1] = sign; break;
                case 6: playField[1, 2] = sign; break;
                case 7: playField[2, 0] = sign; break;
                case 8: playField[2, 1] = sign; break;
                case 9: playField[2, 2] = sign; break;
            }
        }
        public static void WhichCharacter(char playerCharacter, int value)
        { 
            PickSpot(value, playerCharacter);
        }

        public static void WhoWins(char c, int player1, int player2)
        {
            player1Wins = player1;
            player2Wins = player2;

            if (c == 'X')
            {
                Console.WriteLine("\n Player 2 wins");
                Console.WriteLine("You have won {0} games!", ++player2Wins);
            }
            else if(c == 'O')
            {
                Console.WriteLine("\n Player 1 wins");
                Console.WriteLine("You have won {0} games!", ++player1Wins);

            }
            else if(turns == 9)
            {
                Console.WriteLine("Neither player wins it is a Tie! Try again!");
                ResetGame();
            }
            ResetGame();
        }
        public static void ResetGame()
        {
            Console.WriteLine("Press to reset game!");
            Console.ReadKey();
            ResetField();
        }
        
        }
    }   

