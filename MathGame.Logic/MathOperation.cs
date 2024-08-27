using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Logic
{
    public static class MathOperation
    {
        public static int Calculate(int firstNumber, int secondNumber, string operation)
        {
            int operationSum = 0;

            switch (operation)
            {
                case "+":
                    operationSum = firstNumber + secondNumber;
                    break;
                case "-":
                    operationSum = firstNumber - secondNumber;
                    break;
                case "*":
                    operationSum = firstNumber * secondNumber;
                    break;
                case "/":
                    operationSum = firstNumber / secondNumber;
                    break;
                default:
                    Console.WriteLine("Please enter correct format !");
                    break;
            }

            return operationSum;
        }
    }
}
