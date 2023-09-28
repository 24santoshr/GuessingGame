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
                Service service = new Service();

                Console.WriteLine("Enter the amount");
                var betAmount = Console.ReadLine();

                Console.WriteLine("Choose difficulty level, 1: Easy, 2: Medium, 3: Difficult");
                var difficulty = Console.ReadLine();

                Console.WriteLine("Guess Your number");
                var guessNumber = service.getInput();

                var finalResult = service.generateOutput(Convert.ToInt32(betAmount), Convert.ToInt32(guessNumber), Convert.ToInt32(difficulty));
                Console.WriteLine(finalResult);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}