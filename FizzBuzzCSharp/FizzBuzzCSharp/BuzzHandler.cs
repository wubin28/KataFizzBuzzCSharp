namespace FizzBuzzCSharp
{
    public class BuzzHandler : WordHandler
    {
        public BuzzHandler(WordHandler successor) : base(successor)
        {
        }

        public override string Handle(int number)
        {
            if (number%5 == 0)
            {
                return "Buzz";
            }
            return successor.Handle(number);
        }
    }
}