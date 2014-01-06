using System;
using NUnit.Framework;

namespace FizzBuzzCSharp
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        public void WHEN_One_SHOULD_SayOne()
        {
            // Given
            WordHandler wordHandler = new WordHandler();
            // When
            // Then
            Assert.AreEqual("1", wordHandler.Handle(1), "Failure - when 1 should say 1");
        }

        [Test]
        public void WHEN_Three_SHOULD_SayFizz()
        {
            // Given
            WordHandler wordHandler = new WordHandler();
            // When
            // Then
            Assert.AreEqual("Fizz", wordHandler.Handle(3), "Failure - when 3 should say Fizz");
        }
    }
}
