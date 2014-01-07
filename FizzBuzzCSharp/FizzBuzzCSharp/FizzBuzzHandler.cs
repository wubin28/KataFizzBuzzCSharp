namespace FizzBuzzCSharp
{
    public class FizzBuzzHandler : WordHandler
    {
        public FizzBuzzHandler(WordHandler successor) : base(successor)
        {
        }

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