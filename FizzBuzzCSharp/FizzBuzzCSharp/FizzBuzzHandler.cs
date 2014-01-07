namespace FizzBuzzCSharp
{
    public class FizzBuzzHandler : WordHandler
    {
        private readonly FizzHandler _fizzHandler = new FizzHandler();

        public override string Handle(int number)
        {
            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }
            return _fizzHandler.Handle(number);
        }
    }
}