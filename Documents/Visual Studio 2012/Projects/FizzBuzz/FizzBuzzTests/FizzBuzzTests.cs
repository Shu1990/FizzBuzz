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
        [TestCase(0, true)]     //TESTS CORRECT FIRST NUMBER
        [TestCase(2, false)]    //TESTS INCORRECT FIRST NUMBER
        public void TestInputs(int userInputInteger, bool correct)
        {

            bool userGuessIsCorrect = _g.GiveNextNumber(userInputInteger);

            Assert.That(correct, Is.EqualTo(userGuessIsCorrect));
        }




    }
}
