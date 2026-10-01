using UnityEngine;

public class meteorHealth : MonoBehaviour
{
    public int health;
    public enemyDeathScript enemyDeathScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Handles collision with player bullets
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerBullet"))
        {
            health -= 1;
            Destroy(other.gameObject);
            if (health <= 0)
            {
                enemyDeathScript.Die();
            }
        }
        if (other.CompareTag("DoubleDamageBullet"))
        {
            health -= 2;
            Destroy(other.gameObject);
            if (health <= 0)
            {
                enemyDeathScript.Die();
            }
        }
    }
}
