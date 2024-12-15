using UnityEngine;

public class pick_bonus : MonoBehaviour
{
    public MoveMyBalls instance;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            instance.forceJump += 14;
            Destroy(gameObject);
        }
    }
}
