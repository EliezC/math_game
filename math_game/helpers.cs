using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_game
{
    internal class helpers
    {
        static List<string> games = new();

        internal static void ViewPreviousGame()
        {
            Console.Clear();
            Console.WriteLine("Previous Game History");
            Console.WriteLine("---------------------------------------------------------------");
            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Press any key to go back to the main menu.");
            Console.ReadLine();
        }

        internal static void AddToHistory(int gameScore, string gameType)
        {
            games.Add($"{DateTime.Now} - {gameType}: Score = {gameScore}");
        }
    }
}
