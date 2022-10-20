namespace AgilePrinciples.BowlingScorer; 

public class Frame {
    private int score;
    public int Score {
        get { return score; }
    }

    public void Add(int pins) {
        score += pins;
    }
}