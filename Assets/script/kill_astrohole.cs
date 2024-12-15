using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class KillAstrohole : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform player_transform;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Start the scaling coroutine
            StartCoroutine(ScaleDownCoroutine());
        }
    }

    private IEnumerator ScaleDownCoroutine()
    {
        float duration = 0.1f;
        Vector3 originalScale = player_transform.localScale;
        float elapsedTime = 0f;

        rb.constraints = RigidbodyConstraints2D.FreezePosition;
        while (elapsedTime < duration)
        {
            player_transform.localScale = Vector3.Lerp(originalScale, Vector3.zero, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        player_transform.localScale = Vector3.zero;
    }
}
