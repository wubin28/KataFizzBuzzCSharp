using System;
using NUnit.Framework;

namespace FizzBuzzCSharp
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private FizzBuzzHandler _fizzBuzzHandler = null;

        [SetUp]
        public void Init()
        {
            // Given
            _fizzBuzzHandler = new FizzBuzzHandler();
        }

        [Test]
        public void WHEN_One_SHOULD_SayOne()
        {
            // When
            // Then
            Assert.AreEqual("1", _fizzBuzzHandler.Handle(1), "Failure - when 1 should say 1");
        }

        [Test]
        public void WHEN_Three_SHOULD_SayFizz()
        {
            // When
            // Then
            Assert.AreEqual("Fizz", _fizzBuzzHandler.Handle(3), "Failure - when 3 should say Fizz");
        }

        [Test]
        public void WHEN_Five_SHOULD_SayBuzz()
        {
            // When
            // Then
            Assert.AreEqual("Buzz", _fizzBuzzHandler.Handle(5), "Failure - when 5 should say Buzz");
        }

        [Test]
        public void WHEN_Fifteen_SHOULD_SayFizzBuzz()
        {
            // When
            // Then
            Assert.AreEqual("FizzBuzz", _fizzBuzzHandler.Handle(15), "Failure - when 15 should say FizzBuzz");
        }
    }
}
