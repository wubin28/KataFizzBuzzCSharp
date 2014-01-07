namespace FizzBuzzCSharp
{
    public class BuzzHandler : WordHandler
    {
        private readonly CommonNumberHandler successor = new CommonNumberHandler();

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