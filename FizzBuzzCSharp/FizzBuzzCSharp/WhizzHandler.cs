namespace FizzBuzzCSharp
{
    public class WhizzHandler : WordHandler
    {
        public WhizzHandler(WordHandler successor) : base (successor)
        {
        }

        public override string Handle(int number)
        {
            if (number%7 == 0)
            {
                return "Whizz";
            }
            return successor.Handle(number);
        }
    }
}