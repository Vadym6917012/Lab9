using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    [Header("Player statistic")]
    public float playerSpeed = 5f;
    public float playerHealth = 100f;

    [Space]
    [Header("Character sprites")]
    public Sprite playerFront;
    public Sprite playerBack;
    public Sprite playerLeft;
    public Sprite playerRight;

    private Vector2 _movementVector;

    private Rigidbody2D _rbody;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _rbody = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _spriteRenderer.sprite = playerBack;
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            _spriteRenderer.sprite = playerFront;
        } 
        if (Input.GetKeyDown(KeyCode.D))
        {
            _spriteRenderer.sprite = playerRight;
        } 
        if (Input.GetKeyDown(KeyCode.A))
        {
            _spriteRenderer.sprite = playerLeft;
        }
        Move();
    }

    private void Move()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");

        _movementVector = new Vector2(horizontalInput * playerSpeed, verticalInput * playerSpeed);
        _rbody.velocity = _movementVector;
    }
}