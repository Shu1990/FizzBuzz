namespace BowlingGame
{
    public class ScoreCalculator : IScoreCalculator
    {
        public int DetermineFrameScore(int frame, ref int frameIndex, int[] rolls)
        {
            var totalScore = 0;
            if (IsStrike(frame, rolls))
            {
                totalScore += GetStrikeScore(frameIndex, rolls);
                frameIndex++;
            }
            else if (IsSpare(frame, rolls))
            {
                totalScore += GetSpareScore(frameIndex, rolls);
                frameIndex += 2;
            }
            else
            {
                totalScore += GetSinglePinsScore(frameIndex, rolls);
                frameIndex += 2;
            }
            return totalScore;
        }

        private int GetSinglePinsScore(int frameIndex, int[] rolls)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1];
        }

        private int GetSpareScore(int frameIndex, int[] rolls)
        {
            return 10 + rolls[frameIndex + 2];
        }

        private int GetStrikeScore(int frameIndex, int[] rolls)
        {
            return 10 + rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }

        private bool IsSpare(int frameIndex, int[] rolls)
        {
            return (rolls[frameIndex] + rolls[frameIndex + 1] == 10);
        }

        private bool IsStrike(int frameIndex, int[] rolls)
        {
            return (rolls[frameIndex] == 10);
        }
    }
}