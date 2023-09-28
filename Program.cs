using System;
using Game;

namespace GuessingGame
{

    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Service service = new();

                Console.WriteLine("Enter the amount");
                int betAmount = int.Parse(Console.ReadLine());

                Console.WriteLine("Choose difficulty level, 1: Easy, 2: Medium, 3: Difficult");
                int difficulty = int.Parse(Console.ReadLine());

                Console.WriteLine("Guess Your number");
                int guessNumber = service.GetInput();

                string finalResult = Service.GenerateOutput(betAmount, guessNumber, difficulty);
                Console.WriteLine(finalResult);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}