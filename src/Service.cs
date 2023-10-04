namespace Game
{
    public class Service
    {
        public int GetInput()
        {

            int input = int.Parse(Console.ReadLine());
            if ((input) > 20)
            {
                Console.WriteLine("Number is outside the range. Please enter within range");
                GetInput();
            }
            return (input);
        }

        public static string GenerateOutput(int betAmount, int guessNumber, int difficulty)
        {
            return guessNumber switch
            {
                (< 6) when difficulty == 1 => GetFinalResult(guessNumber, 1, 5, 5, betAmount),
                (< 11) when difficulty == 2 => GetFinalResult(guessNumber, 1, 10, 10, betAmount),
                (< 21) when difficulty == 3 => GetFinalResult(guessNumber, 1, 20, 10, betAmount),
                _ => "Guessed number not in range",
            };
        }

        public static string GetFinalResult(int guessNumber, int minRange, int maxRange, int multiplier, int betAmount)
        {
            Random randomNumber = new Random();
            int num = randomNumber.Next(minRange, maxRange);
            if (guessNumber == num)
            {
                int winningAmount = (betAmount * multiplier) + betAmount;
                return $"Congragulations!!! You have won ${winningAmount}";
            }
            else
            {
                return $"You have guessed the wrong number {guessNumber}. The number genrated is {num}.";
            }
        }
    }
}