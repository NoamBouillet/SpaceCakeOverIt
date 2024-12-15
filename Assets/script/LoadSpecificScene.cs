using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadSpecificScene : MonoBehaviour
{
    public string sceneName;
    public Animator fadeSystem;
    public Transform player; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("PlayerScore", (int)(player.position.y + 2));
            StartCoroutine(loadNextScene());
        }
    }

    public IEnumerator loadNextScene()
    {
        fadeSystem.SetTrigger("fadeIn");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }
}
