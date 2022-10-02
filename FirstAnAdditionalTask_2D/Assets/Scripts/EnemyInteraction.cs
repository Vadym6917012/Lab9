using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyInteraction : MonoBehaviour
{
    [Header("Enemy statistic")]
    public float enemyDamage = 12f;

    [Space]
    [Header("Player")]
    [SerializeField] private CharacterController2D _player;

    private BoxCollider2D _boxCollider;

    private void Start()
    {
        _boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (_player.playerHealth <= 0)
        {
            Debug.Log("Died");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (_boxCollider.IsTouchingLayers(LayerMask.GetMask("Player")))
        {
            Attack();
        }
    }

    private void Attack()
    {
        _player.playerHealth -= enemyDamage;
        Debug.Log($"Health: {_player.playerHealth}");
    }
}