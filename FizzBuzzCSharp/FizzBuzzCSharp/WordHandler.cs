namespace FizzBuzzCSharp
{
    public class WordHandler
    {
        public string Handle(int number)
        {
            if (number%3 == 0)
            {
                return "Fizz";
            }
            return number.ToString();
        }
    }
}