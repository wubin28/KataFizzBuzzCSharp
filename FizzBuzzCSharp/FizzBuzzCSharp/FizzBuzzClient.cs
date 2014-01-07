namespace FizzBuzzCSharp
{
    public class FizzBuzzClient
    {
        public WordHandler GetWordHandler()
        {
            WordHandler commonNumberHandler = new CommonNumberHandler(null);
            WordHandler whizzHandler = new WhizzHandler(commonNumberHandler);
            WordHandler buzzHandler = new BuzzHandler(whizzHandler);
            WordHandler fizzHandler = new FizzHandler(buzzHandler);
            WordHandler fizzBuzzHandler = new FizzBuzzHandler(fizzHandler);
            return fizzBuzzHandler;
        }
    }

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