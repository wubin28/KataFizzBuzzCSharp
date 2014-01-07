namespace FizzBuzzCSharp
{
    public class FizzHandler : WordHandler
    {
        public FizzHandler(WordHandler successor) : base(successor)
        {
        }

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