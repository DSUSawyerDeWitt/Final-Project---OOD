using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;
    protected PlayerAwarenessController _playerAwarenessController;
    protected Vector2 _targetDirection;

    [SerializeField]
    protected int _killScore = 10;
    protected ScoreController _scoreController;

    public virtual void AllocateScore()
    {
        _scoreController.AddScore(_killScore);
    }
}
