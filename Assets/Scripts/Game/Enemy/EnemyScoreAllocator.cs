using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScoreAllocator : Enemy
{
//    [SerializeField]
//    private int _killScore;

//    private ScoreController _scoreController;


    private void Awake()
    {
       _scoreController = FindObjectOfType<ScoreController>();
    }

    public override void AllocateScore()
    {
        base.AllocateScore();
    }
}
