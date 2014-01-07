namespace FizzBuzzCSharp
{
    public class BuzzHandler : WordHandler
    {
        private readonly CommonNumberHandler _commonNumberHandler = new CommonNumberHandler();

        public override string Handle(int number)
        {
            if (number%5 == 0)
            {
                return "Buzz";
            }
            return _commonNumberHandler.Handle(number);
        }
    }
}