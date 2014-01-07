namespace FizzBuzzCSharp
{
    public class BuzzHandler
    {
        private string Handle(int number)
        {
            if (number%5 == 0)
            {
                return "Buzz";
            }
            return number.ToString();
        }
    }
}