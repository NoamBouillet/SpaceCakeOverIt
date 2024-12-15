using UnityEngine;

public class death_zone : MonoBehaviour
{
    public camera_moove camera_mooves;
    public Transform camera_transform;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = new Vector3(0.73f, -1.54f, 0);
            camera_transform.position = new Vector3(1,0.4f,-20);
            camera_mooves.isStart = false;
            camera_mooves.verticalMovement = 0;
        }
    }
}
