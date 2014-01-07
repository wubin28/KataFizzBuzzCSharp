namespace FizzBuzzCSharp
{
    public class FizzHandler
    {
        public string Handle(int number)
        {
            if (number%3 == 0)
            {
                return "Fizz";
            }
            if (number%5 == 0)
            {
                return "Buzz";
            }
            return number.ToString();
        }
    }
}