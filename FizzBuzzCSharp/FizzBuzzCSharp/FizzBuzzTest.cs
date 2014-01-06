﻿using System;
using NUnit.Framework;

namespace FizzBuzzCSharp
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private WordHandler wordHandler = null;

        [SetUp]
        public void Init()
        {
            // Given
            wordHandler = new WordHandler();
        }

        [Test]
        public void WHEN_One_SHOULD_SayOne()
        {
            // When
            // Then
            Assert.AreEqual("1", wordHandler.Handle(1), "Failure - when 1 should say 1");
        }

        [Test]
        public void WHEN_Three_SHOULD_SayFizz()
        {
            // When
            // Then
            Assert.AreEqual("Fizz", wordHandler.Handle(3), "Failure - when 3 should say Fizz");
        }
    }
}
