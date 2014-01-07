namespace FizzBuzzCSharp
{
    public abstract class WordHandler
    {
        protected WordHandler successor;

        protected WordHandler(WordHandler successor)
        {
            this.successor = successor;
        }

        public abstract string Handle(int number);
    }
}