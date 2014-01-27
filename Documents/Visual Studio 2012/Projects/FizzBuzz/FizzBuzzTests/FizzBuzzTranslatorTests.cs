using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzzTests
{
    [TestFixture]
    class FizzBuzzTranslatorTests
    {
        private FizzBuzzTranslator _fizzBuzzTranslator;

        [SetUp]
        public void Setup()
        {
            _fizzBuzzTranslator = new FizzBuzzTranslator();
        }

        [Test]
        [TestCase(1, "1")]
        [TestCase(3, "FIZZ")]
        [TestCase(6, "FIZZ")]
        [TestCase(9, "FIZZ")]
        [TestCase(5, "BUZZ")]
        [TestCase(10, "BUZZ")]
        [TestCase(15, "FIZZBUZZ")]
        [TestCase(20, "BUZZ")]
        [TestCase(30, "FIZZBUZZ")]
        public void TestTranslations(int inputNumber, string expectedOutput)
        {
            var fizzBuzzOutput = _fizzBuzzTranslator.DetermineReturnString(inputNumber);
            Assert.That(fizzBuzzOutput, Is.EqualTo(expectedOutput));
        }
    }
}
