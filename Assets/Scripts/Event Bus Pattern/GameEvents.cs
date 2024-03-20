namespace EventBusPattern
{
    public class LevelUpEvent
    {
        public int NewLevel { get; private set; }

        public LevelUpEvent(int newLevel)
        {
            NewLevel = newLevel;
        }
    }

    public class ScoreUpdateEvent
    {
        public int NewScore { get; private set; }

        public ScoreUpdateEvent(int newScore)
        {
            NewScore = newScore;
        }
    }

    public class LevelTimerUpdateEvent
    {
        public float TimeLeft { get; private set; }

        public LevelTimerUpdateEvent(float timeLeft)
        {
            TimeLeft = timeLeft;
        }
    }

}
