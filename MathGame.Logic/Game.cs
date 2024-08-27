
namespace MathGame.Logic
{
    public static class Game
    {
        public static void Start()
        {
            List<string> gameHistoryList = new List<string>();
            string userOperator = " ";
            int firstNumber = 0;
            int secondNumber = 0;
            int result = 0;
            string userInput = " ";

            Message.StarMessage();
            string userName = UserInput.GetUserName("Please enter your name: ");
            Message.WelcomeMessage(userName);

            do
            {
                Message.PrintMenu(userName);

                userOperator = UserInput.GetUserOperator("Enter operator: ");
                firstNumber = UserInput.GetUserNumber("Please enter first number: ");
                secondNumber = UserInput.GetUserNumber("Please enter second number: ");
                result = MathOperation.Calculate(firstNumber, secondNumber, userOperator);

                string gameResult = UserInput.GetGameResult(firstNumber, secondNumber, result, userOperator);
                gameHistoryList.Add(gameResult);

                Message.PrintResult(firstNumber, secondNumber, result, userOperator);
                userInput = UserInput.GetUserChoice("Enter choice: ");

                if (userInput.ToLower() == "h")
                {
                    GameHistory.ShowHistory(gameHistoryList, userName);
                } 
            } while (userInput.ToLower() != "exit");
        }

    }
}
