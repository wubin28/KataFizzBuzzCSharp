namespace FizzBuzzCSharp
{
    public class FizzHandler : WordHandler
    {
        private readonly BuzzHandler _buzzHandler = new BuzzHandler();

        public override string Handle(int number)
        {
            if (number%3 == 0)
            {
                return "Fizz";
            }
            return _buzzHandler.Handle(number);
        }
    }
}