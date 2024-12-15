using UnityEngine;

public class MoveMyBalls : MonoBehaviour
{
    public float movespeed;
    public Rigidbody2D rb;
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    private Vector3 velocity =  Vector3.zero;
    public bool isJumping = false;
    public float forceJump;
    public AudioClip sound;
    public AudioSource audio;

    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * movespeed * Time.fixedDeltaTime;

        if (Input.GetButtonDown("Jump")) {
            isJumping = true;
        }
        move(horizontalMovement);

        flip(rb.linearVelocity.x);

        float characterVelocity = Mathf.Abs(rb.linearVelocity.x);
        animator.SetFloat("Speed", characterVelocity);
    }

    void move(float _horizontalMovement)
    {
        Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.linearVelocity.y);
        rb.linearVelocity = Vector3.SmoothDamp(rb.linearVelocity, targetVelocity, ref velocity, .05f);

        if (isJumping == true) {
            audio.PlayOneShot(sound);
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);
            rb.AddForce(new Vector2(0f, forceJump));
            isJumping = false;
        }
    }

    void flip(float _velocity)
    {
        if (_velocity > 0.1f) {
            spriteRenderer.flipX = false;
        } else if (_velocity < 0.1f) {
            spriteRenderer.flipX = true;
        }
    }
}
