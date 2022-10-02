using UnityEngine;

public class HealPlayer : MonoBehaviour
{
    public float heal = 100f;

    [SerializeField] private CharacterController2D _player;

    private BoxCollider2D _boxCollider;

    void Start()
    {
        _boxCollider = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (_boxCollider.IsTouchingLayers(LayerMask.GetMask("Player")))
        {
            Heal();
        }
    }

    private void Heal()
    {
        if (_player.playerHealth == 100f)
            Debug.Log("Yo`re healthy");

        if (_player.playerHealth < 100)
        {
            _player.playerHealth = 100f;
            Debug.Log("You`re healed");
        }
    }
}