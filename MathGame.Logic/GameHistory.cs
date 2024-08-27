using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Logic
{
    public static class GameHistory
    {
        public static void ShowHistory(List<string> gameHistoryList, string userName)
        {
            Console.WriteLine("______________________________________");
            Console.WriteLine($"{userName}, Your game history : ");

            for (int i = 0; i < gameHistoryList.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {gameHistoryList[i]}");
            }

            Console.WriteLine("______________________________________");

        }
    }
}
