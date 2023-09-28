namespace Game
{
    public class Service
    {

        public int getInput()
        {

            var input = Console.ReadLine();

            if (Convert.ToInt32(input) > 20)
            {
                Console.WriteLine("Number is outside range. Please enter within range");

                getInput();


            }

            return Convert.ToInt32(input);
        }

        public string generateOutput(int betAmount, int guessNumber, int difficulty)
        {

            switch (guessNumber)
            {
                case (< 6) when difficulty == 1:
                    return getFinalResult(guessNumber, 1, 5, 5, betAmount);


                case (< 11) when difficulty == 2:
                    return getFinalResult(guessNumber, 1, 10, 10, betAmount);


                case (< 21) when difficulty == 3:
                    return getFinalResult(guessNumber, 1, 20, 10, betAmount);

                default:
                    return "Guessed number not in range";
            }
        }

        public string getFinalResult(int guessNumber, int minRange, int maxRange, int multiplier, int betAmount)
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
                return $"You have guessed the wrong number {guessNumber}. The number genrated is {num}";
            }
        }
    }
}