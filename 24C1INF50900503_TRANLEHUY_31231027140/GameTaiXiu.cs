using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_TRANLEHUY_31231027140
{
    internal class GameTaiXiu
    {
        public static void Main()
        {
            Game_engine();
        }
        static int rollDice()
        {
            Random rnd = new Random();
            int die_1 = rnd.Next(6) + 1;
            int die_2 = rnd.Next(6) + 1;
            int die_3 = rnd.Next(6) + 1;
            int sum_of_dice = die_1 + die_2 + die_3;
            return sum_of_dice;
        }
        static void playOneRound()
        {
            int comp_dice = rollDice();
            Console.WriteLine("Chao mung den voi Gam Tai Xiu");
            Console.Write("Ban doan Tai hay Xiu <T/X>");
            string user_guessing = Console.ReadLine();
            if (user_guessing.ToUpper().Equals("T"))
            {
                if (comp_dice >= 10) //Tài
                    Console.WriteLine("You win");
                else
                    Console.WriteLine("You lose");
            }
            else if (user_guessing.ToUpper().Equals("X"))
            {
                if (comp_dice < 10)//Xỉu
                    Console.WriteLine("You win");
                else
                    Console.WriteLine("You lose");
            }
            else
            {
                Console.WriteLine("Vui long chon lai cho dung");
            }
        }
        static void Game_engine()
        {
            int count = 0;
            do
            {
                playOneRound();
                count++;
                Console.Write("Ban co muon choi tiep khong? <C/K>");
                string choice = Console.ReadLine();
                if (choice.ToUpper().Equals("K"))
                {
                    Console.WriteLine("Bye bye! Mai choi tiep nha");
                    Console.WriteLine($"Hom nay ban da choi {count} ban!");
                    break;
                }
            } while (true);
        }
    }
}
