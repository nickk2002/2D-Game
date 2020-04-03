using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;

    [SerializeField]
    float xSpeed;

    [SerializeField]
    float ySpeed;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(3f, rb2d.velocity.y);
            spriteRenderer.flipX = false;
            animator.Play("megaman_running");
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-3f, rb2d.velocity.y);
            spriteRenderer.flipX = true;
            animator.Play("megaman_running");
        }
        if (Input.GetKey("space"))
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, ySpeed);
            animator.Play("megaman_jumping");
        }
        else
        {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
            animator.Play("megaman_idle");
        }
    }
}
