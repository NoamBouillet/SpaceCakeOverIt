using UnityEngine;

public class camera_moove : MonoBehaviour
{
    public float movespeed;
    public Rigidbody2D rb;
    private Vector3 velocity =  Vector3.zero;
    public float speed; 
    public bool isStart = false;

    public float verticalMovement;
    void Update()
    {
        if (Input.GetButtonDown("Jump")) {
            isStart = true;
        }
        if (isStart == true) {
            movespeed += speed;
            verticalMovement = movespeed * Time.fixedDeltaTime;
            move(verticalMovement);
        }
    }
    void move(float _verticalMovement)
    {
        Vector3 targetVelocity = new Vector2(0, _verticalMovement);
        rb.linearVelocity = Vector3.SmoothDamp(rb.linearVelocity, targetVelocity, ref velocity, .05f);
    }
}
