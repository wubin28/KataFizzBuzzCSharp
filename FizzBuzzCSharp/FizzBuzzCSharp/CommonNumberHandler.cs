namespace FizzBuzzCSharp
{
    public class CommonNumberHandler : WordHandler
    {
        public CommonNumberHandler(WordHandler successor) : base (successor)
        {
        }

        public override string Handle(int number)
        {
            return number.ToString();
        }
    }
}