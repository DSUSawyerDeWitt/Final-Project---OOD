using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : Player
{

    [SerializeField]
    private float _rotationSpeed;

    private Animator _animator;

  //  public Camera cam;
    Vector2 mousePos;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        //from pixel cordinates to world units.
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    private void FixedUpdate()
    {
        SetPlayerVelocity();
        RotateInDirectionOfInput();
        RotateinDirectionofMouse();
    }

    private void RotateinDirectionofMouse()
    {
        Vector2 lookDir = mousePos - _rigidbody.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        _rigidbody.rotation = angle;
    }
    protected override void SetPlayerVelocity()
    {
        _smoothedMovementInput = Vector2.SmoothDamp(
            _smoothedMovementInput,
            _movementInput,
            ref _movementInputSmoothVelocity, 0.1f);
        _rigidbody.velocity = _smoothedMovementInput * (_speed * 2); //faster speed
    }
    private void RotateInDirectionOfInput()
    {
        if (_movementInput != Vector2.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(transform.forward, _smoothedMovementInput);
            Quaternion rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, _rotationSpeed * Time.deltaTime);

            _rigidbody.MoveRotation(rotation);
        }
    }
    private void OnMove(InputValue inputValue) //method
    {
        _movementInput = inputValue.Get<Vector2>();
    }
}
