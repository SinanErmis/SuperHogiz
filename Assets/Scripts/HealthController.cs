using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    public int health = 3;
    public Image[] heartImages;
    public Sprite emptyHeart;
    public GameObject deathScreen;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Border"))
        {
            Die();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("Enemy"))
        {
            health -= 1;
            heartImages[health].sprite = emptyHeart;
            // ui'i guncelle
            
            //
            if (health <= 0)
            {
                Die();
            }
            else
            {
                transform.position = new Vector3(0, 1, 0);
            }
        }
    }

    void Die()
    {
        deathScreen.SetActive(true);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
