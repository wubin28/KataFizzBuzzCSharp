namespace FizzBuzzCSharp
{
    public class BuzzHandler : WordHandler
    {
        public override string Handle(int number)
        {
            if (number%5 == 0)
            {
                return "Buzz";
            }
            return Handle(number);
        }

        public string Handle(int number)
        {
            return number.ToString();
        }
    }
}