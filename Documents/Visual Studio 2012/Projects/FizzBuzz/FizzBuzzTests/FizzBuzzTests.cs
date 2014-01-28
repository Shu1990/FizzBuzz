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
    public class FizzBuzzGameTest
    {
        
        private FizzBuzzGame _g;

        [SetUp]
        public void Setup()
        {
            var fizzBuzzTranslator = new FizzBuzzTranslator();
            _g = new FizzBuzzGame(fizzBuzzTranslator);
        }
        
        [Test]
        [TestCase(1, true)]     //TESTS CORRECT FIRST NUMBER
        [TestCase(2, false)]    //TESTS INCORRECT FIRST NUMBER
        public void TestFirstInputs(int userInputInteger, bool correct)
        {
            string integerAsString = userInputInteger.ToString();

            bool userGuessIsCorrect = _g.ProvideNextValue(integerAsString);
            Assert.That(correct, Is.EqualTo(userGuessIsCorrect));
        }


        [Test]
        public void TestOneThroughFifteen()
        {
            var userGuessIsCorrect = _g.ProvideNextValue("1");

            userGuessIsCorrect = _g.ProvideNextValue("2");

            userGuessIsCorrect = _g.ProvideNextValue("FIZZ");

            userGuessIsCorrect = _g.ProvideNextValue("4");

            userGuessIsCorrect = _g.ProvideNextValue("BUZZ");

            userGuessIsCorrect = _g.ProvideNextValue("FIZZ");

            userGuessIsCorrect = _g.ProvideNextValue("7");

            userGuessIsCorrect = _g.ProvideNextValue("8");

            userGuessIsCorrect = _g.ProvideNextValue("FIZZ");

            userGuessIsCorrect = _g.ProvideNextValue("BUZZ");

            userGuessIsCorrect = _g.ProvideNextValue("11");

            userGuessIsCorrect = _g.ProvideNextValue("FIZZ");

            userGuessIsCorrect = _g.ProvideNextValue("13");

            userGuessIsCorrect = _g.ProvideNextValue("14");

            userGuessIsCorrect = _g.ProvideNextValue("FIZZBUZZ");
            Assert.IsTrue(userGuessIsCorrect);

        }
    }
}
