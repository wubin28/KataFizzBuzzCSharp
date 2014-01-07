namespace FizzBuzzCSharp
{
    public class FizzBuzzClient
    {
        public FizzBuzzHandler GetWordHandler()
        {
            return new FizzBuzzHandler();
        }
    }
}