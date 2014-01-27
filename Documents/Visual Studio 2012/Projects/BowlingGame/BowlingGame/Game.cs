using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Game
    {
        private readonly ScoreCalculator _scoreCalculator;
        private readonly int[] _rolls = new int[21];
        private int _currentRoll = 0;

        public Game(ScoreCalculator scoreCalculator)
        {
            _scoreCalculator = scoreCalculator;
        }

        public void Roll(int pins)
        {
            _rolls[_currentRoll++] = pins;
        }

        public int Score()
        {
            var totalScore = 0;
            var frameIndex = 0;
            for (var frame = 0; frame < 10; frame++)
                totalScore += _scoreCalculator.DetermineFrameScore(frame, ref frameIndex, _rolls);

            return totalScore;
        }

    }
}
