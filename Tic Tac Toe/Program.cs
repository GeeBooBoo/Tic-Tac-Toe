using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[10] { null, "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            int winner = 0;
            int player = 1;
            int changeTurn = 0;

            Console.WriteLine("Select the number corresponding to the place you want to mark. (0) is a invalid input");
            updatedDrawning(arr);

            do
            {
                string user = Console.ReadLine();
                int input;

                Console.Clear();

                if (int.TryParse(user, out input) && input != 0)
                {
                    if (changeTurn % 2 == 0)
                    {
                        Console.WriteLine(" It's 0 turn now!");
                        player = 1;
                    }
                    else
                    {
                        Console.WriteLine(" It's X turn now!");
                        player = 2;
                    }
                }
                else
                {
                    Console.WriteLine("Please insert a valid Number! Also (0) is a invalid input");
                }
                
                string lastInput = userInput(input, player, arr);

                updatedDrawning(arr);

                winner = checkWinner(arr);
                if (winner == 1) { Console.WriteLine($" {lastInput} won"); }
                else if (winner == 2) { Console.WriteLine(" Draw"); }

                changeTurn++;

            } while (winner != 1 && winner != 2);
        }
        
        public static void updatedDrawning(string[] arr)
        {
            Console.WriteLine($"{arr[7]}  {arr[8]}  {arr[9]}");
            Console.WriteLine($"{arr[4]}  {arr[5]}  {arr[6]}");
            Console.WriteLine($"{arr[1]}  {arr[2]}  {arr[3]}");
        }
        
        public static int checkWinner(string[] arr)
        {
            if (
                //check horizontal
                arr[7] == arr[8] && arr[8] == arr[9] ||
                arr[4] == arr[5] && arr[5] == arr[6] ||
                arr[1] == arr[2] && arr[2] == arr[3] ||
                //check vertical
                arr[7] == arr[4] && arr[4] == arr[1] ||
                arr[8] == arr[5] && arr[5] == arr[2] ||
                arr[9] == arr[6] && arr[6] == arr[3] ||
                //check diagonal
                arr[7] == arr[5] && arr[5] == arr[3] ||
                arr[9] == arr[5] && arr[5] == arr[1])
            {
                return 1;
            }
            if (
               //check Draw 
               arr[7] != "7" && arr[8] != "8" && arr[9] != "9" &&
               arr[4] != "4" && arr[5] != "5" && arr[6] != "6" &&
               arr[1] != "1" && arr[2] != "2" && arr[3] != "3")
            {
                return 2;
            }
            return 0;
        }
        
        public static string userInput(int input, int playerTurn, string[] arr)
        {
            string turn = null;

            if (playerTurn == 1)
            {
                turn = "X";
            }
            else if (playerTurn == 2)
            {
                turn = "0";
            }

            switch (input)
            {
                case 1:
                    //this prevents the player from overwriting the same place
                    if (arr[1] == "1") { arr[1] = turn; }
                    break;
                case 2:
                    if (arr[2] == "2") { arr[2] = turn; }
                    break;
                case 3:
                    if (arr[3] == "3") { arr[3] = turn; }
                    break;
                case 4:
                    if (arr[4] == "4") { arr[4] = turn; }
                    break;
                case 5:
                    if (arr[5] == "5") { arr[5] = turn; }
                    break;
                case 6:
                    if (arr[6] == "6") { arr[6] = turn; }
                    break;
                case 7:
                    if (arr[7] == "7") { arr[7] = turn; }
                    break;
                case 8:
                    if (arr[8] == "8") { arr[8] = turn; }
                    break;
                case 9:
                    if (arr[9] == "9") { arr[9] = turn; }
                    break;
            }
            return turn;
        }
    }
}
