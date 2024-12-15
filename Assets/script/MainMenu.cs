using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    public Animator fadeSystem;

    public void PlayGame()
    {
        StartCoroutine(loadNextScene());
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public IEnumerator loadNextScene()
    {
        fadeSystem.SetTrigger("fadeIn");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadSceneAsync(1);
    }
}