using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterController2D : MonoBehaviour
{
    public float playerSpeed = 5f;

    public Sprite player;
    public Sprite playerBack;
    public Sprite playerLeft;
    public Sprite playerRight;

    private Vector2 _movementVector;

    private Rigidbody2D _rbody;
    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _rbody = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _spriteRenderer.sprite = playerBack;
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            _spriteRenderer.sprite = player;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
