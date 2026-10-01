using UnityEngine;

public class enemySniperScript : MonoBehaviour
{
    public int health;
    public enemyDeathScript enemyDeathScript;
    public float lifetime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifetime -= Time.deltaTime;
    }

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

    void OnBecameInvisible()
    {
        if (lifetime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
