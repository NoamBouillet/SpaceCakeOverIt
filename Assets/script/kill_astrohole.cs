using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class KillAstrohole : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform player_transform;
    public Animator fadeSystem;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Start the scaling coroutine
            PlayerPrefs.SetInt("PlayerScore", (int)(player_transform.position.y + 2));
            StartCoroutine(ScaleDownCoroutine());
            StartCoroutine(loadNextScene());
        }
    }

    private IEnumerator ScaleDownCoroutine()
    {
        float duration = 0.9f;
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
    public IEnumerator loadNextScene()
    {
        fadeSystem.SetTrigger("fadeIn");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("GameOver");
    }
}
