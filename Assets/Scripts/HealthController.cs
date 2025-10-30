using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    public int health = 3;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Border"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            health -= 1;
            if (health <= 0)
            {
                SceneManager.LoadScene("SampleScene");
            }
            else
            {
                transform.position = new Vector3(0, 1, 0);
            }
        }
    }
}
