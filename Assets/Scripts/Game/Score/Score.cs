using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int currentscore;
    public int highScore;

    protected virtual void ResetScore()
    {
        currentscore = 0;
    }
}
