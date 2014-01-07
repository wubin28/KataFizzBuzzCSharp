namespace FizzBuzzCSharp
{
    public class FizzHandler : WordHandler
    {
        public override string Handle(int number)
        {
            if (number%3 == 0)
            {
                return "Fizz";
            }
            return Handle(number);
        }

        public string Handle(int number)
        {
            if (number%5 == 0)
            {
                return "Buzz";
            }
            return number.ToString();
        }
    }
}