using UnityEngine;

public class pick_bonus : MonoBehaviour
{
    public MoveMyBalls instance;
    public int forceBonus;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            instance.forceJump += forceBonus;
            Destroy(gameObject);
        }
    }
}
