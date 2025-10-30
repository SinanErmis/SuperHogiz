using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce = 10f;
    public float speed = 2;

    public void Update()
    {
        // Eger space tusuna basildiysa
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            // Yukari zipla

            rb.AddForce(Vector2.up * jumpForce);
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
}
