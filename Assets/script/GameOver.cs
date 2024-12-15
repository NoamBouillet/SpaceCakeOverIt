using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void MenuGame()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
