namespace FizzBuzz
{
    public class FizzBuzzTranslator : IFizzBuzzTranslator
    {
        private const int FizzDivisor = 3;
        private const string Fizz = "FIZZ";

        private const int BuzzDivisor = 5;
        private const string Buzz = "BUZZ";
        private const string FizzBuzz = "FIZZBUZZ";

        public string DetermineReturnString(int givenInteger)
        {
            if (FizzDivisible(givenInteger) && BuzzDivisible(givenInteger))
                return FizzBuzz;
            else if (FizzDivisible(givenInteger))
                return Fizz;
            else if (BuzzDivisible(givenInteger))
                return Buzz;
            else
                return givenInteger.ToString();
        }

        private static bool BuzzDivisible(int givenInteger)
        {
            return givenInteger % BuzzDivisor == 0;
        }

        private bool FizzDivisible(int givenInteger)
        {
            return givenInteger % FizzDivisor == 0;
        }

    }
}
