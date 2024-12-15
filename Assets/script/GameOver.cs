using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOver : MonoBehaviour
{
    public Animator fadeSystem;
    public void RestartGame()
    {
        StartCoroutine(loadNextScene());
    }

    public void MenuGame()
    {
        StartCoroutine(loadNextScene2());
    }

    public IEnumerator loadNextScene()
    {
        fadeSystem.SetTrigger("fadeIn");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadSceneAsync(1);
    }

     public IEnumerator loadNextScene2()
    {
        fadeSystem.SetTrigger("fadeIn");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadSceneAsync(0);
    }
}
