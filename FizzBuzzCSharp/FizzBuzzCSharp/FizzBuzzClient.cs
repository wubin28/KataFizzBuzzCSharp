namespace FizzBuzzCSharp
{
    public class FizzBuzzClient
    {
        public WordHandler GetWordHandler()
        {
            WordHandler commonNumberHandler = new CommonNumberHandler(null);
            WordHandler buzzHandler = new BuzzHandler(commonNumberHandler);
            WordHandler fizzHandler = new FizzHandler(buzzHandler);
            WordHandler fizzBuzzHandler = new FizzBuzzHandler(fizzHandler);
            return fizzBuzzHandler;
        }
    }
}