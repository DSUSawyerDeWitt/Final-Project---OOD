using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    protected float _speed;
    protected Vector2 _movementInput; //stores an x,y value
    protected Vector2 _smoothedMovementInput;
    protected Vector2 _movementInputSmoothVelocity;
    protected Rigidbody2D _rigidbody;

    public Camera cam;

    public Player()
    {
        _speed = 2.5f;
    }

    private void Awake()
    {
        cam = Camera.main;
    }

    protected virtual void SetPlayerVelocity()
    {
        _smoothedMovementInput = Vector2.SmoothDamp(
            _smoothedMovementInput,
            _movementInput,
            ref _movementInputSmoothVelocity, 0.1f);
        _rigidbody.velocity = _smoothedMovementInput * _speed; //(x,y) * speed
    }
}
