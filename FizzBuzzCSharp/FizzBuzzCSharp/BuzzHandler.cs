namespace FizzBuzzCSharp
{
    public class BuzzHandler
    {
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