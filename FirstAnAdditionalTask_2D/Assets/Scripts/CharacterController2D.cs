using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    [Header("Player statistic")]
    public float playerSpeed = 5f;
    public float playerHealth = 100f;

    private Vector2 _movementVector;

    private Rigidbody2D _rbody;
    private SpriteRenderer _spriteRenderer;
    private Animator _animator;

    private void Start()
    {
        _rbody = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");

        _animator.SetFloat("Horizontal", _movementVector.x);
        _animator.SetFloat("Vertical", _movementVector.y);
        _animator.SetFloat("Speed", _movementVector.sqrMagnitude);

        _movementVector = new Vector2(horizontalInput * playerSpeed, verticalInput * playerSpeed);
        _rbody.velocity = _movementVector;
    }
}