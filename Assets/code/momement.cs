using UnityEngine;

public class PlayerMomement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    public float jumpForce = 6f;
    private bool isJumping = false; // Track if the player is jumping

    void Start()
    {
        
    }

    void Update()
    {
        // Move right
        if (Input.GetKey("d"))
        {
            rb.linearVelocity = new Vector2(speed, rb.linearVelocity.y);
        }
        // Move left
        if (Input.GetKey("a"))
        {
            rb.linearVelocity = new Vector2(-speed, rb.linearVelocity.y);
        }
        // Jump
        if (Input.GetKeyDown("w") && !isJumping) // Use GetKeyDown for one-time action
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            isJumping = true; // Set jumping state
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Reset jumping state when landing
        if (collision.gameObject.CompareTag("Ground")) // Ensure the ground is tagged correctly
        {
            isJumping = false; // Allow jumping again
        }
    }
}
