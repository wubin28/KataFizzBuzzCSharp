namespace FizzBuzzCSharp
{
    public class FizzHandler : WordHandler
    {
        private readonly BuzzHandler successor = new BuzzHandler();

        public override string Handle(int number)
        {
            if (number%3 == 0)
            {
                return "Fizz";
            }
            return successor.Handle(number);
        }
    }
}