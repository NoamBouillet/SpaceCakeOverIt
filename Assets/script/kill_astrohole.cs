using Unity.VisualScripting;
using UnityEngine;

public class kill_astrohole : MonoBehaviour
{
    public Rigidbody2D rb;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
        }
    }
}
