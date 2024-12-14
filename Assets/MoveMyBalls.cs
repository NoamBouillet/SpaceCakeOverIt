using UnityEngine;

public class MoveMyBalls : MonoBehaviour
{
    public float movespeed;
    public Rigidbody2D rb;
    private Vector3 velocity =  Vector3.zero;
    public bool isJumping = false;
    public float forceJump;

    void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * movespeed * Time.deltaTime;

        if (Input.GetButtonDown("Jump")) {
            isJumping = true;
        }
        move(horizontalMovement);
    }

    void move(float _horizontalMovement)
    {
        Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.linearVelocity.y);
        rb.linearVelocity = Vector3.SmoothDamp(rb.linearVelocity, targetVelocity, ref velocity, .05f);

        if (isJumping == true) {
            rb.AddForce(new Vector2(0f, forceJump));
            isJumping = false;
        }
    }
}
