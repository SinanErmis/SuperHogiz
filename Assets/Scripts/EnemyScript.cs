using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 2f;

    void Update()
    {
        rb.linearVelocity = new Vector2(speed, rb.linearVelocityY);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyPoint"))
        {
            speed = speed * - 1;
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }
    }
}
