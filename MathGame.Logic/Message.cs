using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Logic
{
    public static class Message
    {
        public static void WelcomeMessage(string userName)
        {
            Console.WriteLine($"Hello {userName}, This is math game. enjoy!");
        }

        public static void StarMessage()
        {
            Console.WriteLine("Starting math game..!");
        }

        public static void PrintResult(int firstNumber, int secondNumber, int sum, string operation)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"RESULT = {firstNumber} {operation} {secondNumber} = {sum}");
        }

        public static void PrintMenu(string userName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{userName} Choose which operation do you want: ");
            Console.WriteLine("______________________________________________");
            Console.WriteLine("For addition enter [+] symbol");
            Console.WriteLine("For subtraction enter [-] symbol");
            Console.WriteLine("For Multiply enter [*] symbol");
            Console.WriteLine("For Divide enter [/] symbol");
        }

        public static void PrintExitOrHistoryMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("______________________________________________");
            Console.WriteLine("For exit please enter 'Exit'.");
            Console.WriteLine("To view history enter 'H'.");
            Console.WriteLine("To play againg enter any key or text..");
            Console.WriteLine("______________________________________________");
        }
    }
}
