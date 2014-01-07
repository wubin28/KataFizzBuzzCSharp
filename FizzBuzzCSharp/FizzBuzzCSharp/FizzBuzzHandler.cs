namespace FizzBuzzCSharp
{
    public class FizzBuzzHandler : WordHandler
    {
        private readonly FizzHandler successor = new FizzHandler();

        public override string Handle(int number)
        {
            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }
            return successor.Handle(number);
        }
    }
}