using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce = 10f;
    public float speed = 2;
    public bool isGrounded = true;
    public void Update()
    {
        // Eger space tusuna basildiysa
        if (Keyboard.current.wKey.wasPressedThisFrame && isGrounded)
        {
            // Yukari zipla

            rb.AddForce(Vector2.up * jumpForce);
            isGrounded = false;
        }

        if (Keyboard.current.dKey.isPressed)
        {
            // rb.linearVelocityX = speed;

            rb.linearVelocity = new Vector2(speed, rb.linearVelocity.y);
        }


        if (Keyboard.current.aKey.isPressed)
        {
            // rb.linearVelocityX = -speed;

            rb.linearVelocity = new Vector2(-speed, rb.linearVelocity.y);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("FinishLine"))
        {
            SceneManager.LoadScene("SampleScene");
        }
        
    }


}
