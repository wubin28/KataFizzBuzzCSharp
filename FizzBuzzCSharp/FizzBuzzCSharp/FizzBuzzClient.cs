namespace FizzBuzzCSharp
{
    public class FizzBuzzClient
    {
        public WordHandler GetWordHandler()
        {
            WordHandler commonNumberHandler = new CommonNumberHandler(null);
            WordHandler whizzHandler = new WhizzHandler(commonNumberHandler)
            WordHandler buzzHandler = new BuzzHandler(whizzHandler);
            WordHandler fizzHandler = new FizzHandler(buzzHandler);
            WordHandler fizzBuzzHandler = new FizzBuzzHandler(fizzHandler);
            return fizzBuzzHandler;
        }
    }
}