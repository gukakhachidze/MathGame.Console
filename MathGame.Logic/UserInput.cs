using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Logic
{
    public static class UserInput
    {
        public static int GetUserNumber(string text)
        {
            int userNumber = 0;

            Console.Write(text);
            string userTextInput = Console.ReadLine();
            bool isValidNumber = int.TryParse(userTextInput, out userNumber);
            bool isValidRangeNumber = ValidateInput(userNumber);

            while (isValidNumber == false || isValidRangeNumber == false)
            {
                Console.Write(text);
                userTextInput = Console.ReadLine();
                isValidNumber = int.TryParse(userTextInput, out userNumber);
                isValidRangeNumber = ValidateInput(userNumber);
            }

            return userNumber;

        }
        public static string GetUserOperator(string text)
        {
            Console.Write(text);
            string userOperator = Console.ReadLine();
            bool isValidInput = userOperator == "+" || userOperator == "-" || userOperator == "*" ||
                userOperator == "/";

            while (!isValidInput)
            {
                Console.WriteLine("Please enter operator to correct format!(+, -, *, /)");
                Console.Write(text);
                userOperator = Console.ReadLine();
                isValidInput = (userOperator == "+" || userOperator == "-") || (userOperator == "*" ||
                userOperator == "/");
            }

            return userOperator;
        }

        private static bool ValidateInput(int userInput)
        {
            if (userInput <= 0 ||  userInput >= 100)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static string GetUserName(string text)
        {
            Console.Write(text);
            string userName = Console.ReadLine();

            while(string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(userName))
            {
                Console.WriteLine("Enter your name correct !");
                Console.Write(text);
                userName = Console.ReadLine();
            }

            return userName;
        }

        public static string GetGameResult(int firstNumber, int secondNumber, int sum, string operation)
        {
            string result = $"{firstNumber} {operation} {secondNumber} = {sum}";
            return result;
        }

        public static string GetUserChoice(string text)
        {
            string userInput = " ";

            do
            {
                Message.PrintExitOrHistoryMenu();
                Console.Write(text);
                userInput = Console.ReadLine(); 

            } while (string.IsNullOrEmpty(userInput));

            return userInput;
        }
    }
}
