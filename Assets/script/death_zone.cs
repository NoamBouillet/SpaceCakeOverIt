using UnityEngine;
using UnityEngine.SceneManagement;

public class death_zone : MonoBehaviour
{
    public camera_moove camera_mooves;
    public Transform camera_transform;
    public Transform player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("PlayerScore", (int)(player.position.y + 2));
            SceneManager.LoadSceneAsync(2);
        }
    }
}
