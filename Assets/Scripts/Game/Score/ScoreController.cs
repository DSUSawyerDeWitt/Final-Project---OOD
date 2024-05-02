using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreController : Score
{
    public UnityEvent OnScoreChanged;
    //   public int Score {  get; private set; }
    private int score;
    public int Score
    {
        get { return score; }
        set
        {
            if(value < 0)
            {
                score = 0;
            }
            else
            {
                score = value;
            }
        }
    }
    public void AddScore(int amount)
    {
        Score += amount;
        OnScoreChanged.Invoke();
    }

    protected override void ResetScore()
    {
        base.ResetScore();
    }
}
