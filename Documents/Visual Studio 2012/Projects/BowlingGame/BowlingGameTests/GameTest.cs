using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BowlingGame;
using NUnit.Framework;

namespace BowlingGameTests
{
    [TestFixture]
    public class GameTest
    {
        private Game _g;

        [SetUp]
        public void SetUp()
        {
            var scoreCalculator = new ScoreCalculator();
            _g = new Game(scoreCalculator);
        }

        private void RollMany(int n, int pins)
        {
            for (var i = 0; i < n; i++)
                _g.Roll(pins);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 20)]
        [TestCase(2, 40)]
        [TestCase(3, 60)]
        [TestCase(4, 80)]
        public void TestGutterGame(int pins, int expectedScore)
        {
            const int n = 20;

            RollMany(n, pins);

            var gameScore = _g.Score();
            Assert.That(expectedScore, Is.EqualTo(gameScore));
        }

        [Test]
        public void TestOneSpare()
        {

            const int expectedScore = 16;

            Spare();
            _g.Roll(3);

            RollMany(17, 0);
            Assert.That(expectedScore, Is.EqualTo(_g.Score()));

        }

        [Test]
        public void TestOneStrike()
        {

            const int expectedScore = 26;

            Strike(); //strike
            _g.Roll(5);
            _g.Roll(3);

            RollMany(16, 0);
            Assert.That(expectedScore, Is.EqualTo(_g.Score()));

        }

        private void Strike()
        {
            _g.Roll(10);
        }


        private void Spare()
        {
            _g.Roll(5);
            _g.Roll(5);
        }

    }
}
