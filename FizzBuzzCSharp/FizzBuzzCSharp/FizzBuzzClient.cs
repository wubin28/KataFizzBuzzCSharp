namespace FizzBuzzCSharp
{
    public class FizzBuzzClient
    {
        public WordHandler GetWordHandler()
        {
            return new FizzBuzzHandler();
        }
    }
}