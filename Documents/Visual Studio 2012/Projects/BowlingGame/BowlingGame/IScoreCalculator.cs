namespace BowlingGame
{
    public interface IScoreCalculator
    {
        int DetermineFrameScore(int frame, ref int frameIndex, int[] rolls);
    }
}