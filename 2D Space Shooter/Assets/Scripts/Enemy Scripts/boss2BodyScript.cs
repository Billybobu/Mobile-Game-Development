using UnityEngine;

public class boss2BodyScript : MonoBehaviour
{
    public int bodyHealth;
    private boss2Head boss2Head;
    bool turretDestroyed = false;
    public GameObject wasp;
    public level2Spawner level2Spawner;
    public boss2Death boss2Death;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (level2Spawner.bossDefeated == true)
        {
            boss2Death.Die();
        }
    }

    void Awake()
    {
        boss2Head = FindFirstObjectByType<boss2Head>();
        level2Spawner = FindFirstObjectByType<level2Spawner>();
    }

    // Handles collision with player bullets
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerBullet"))
        {
            bodyHealth -= 1;
            boss2Head.TakeDamage(1);
            Destroy(other.gameObject);
            if (bodyHealth <= 0 && turretDestroyed == false)
            {
                GetComponentsInChildren<enemyDeathScript>()[0].Die(); // Destroys the turret
                Instantiate(wasp, transform.position, Quaternion.identity);
                turretDestroyed = true;
            }
        }
        if (other.CompareTag("DoubleDamageBullet"))
        {
            bodyHealth -= 2;
            boss2Head.TakeDamage(2);
            Destroy(other.gameObject);
            if (bodyHealth <= 0 && turretDestroyed == false)
            {
                GetComponentsInChildren<enemyDeathScript>()[0].Die(); // Destroys the turret
                Instantiate(wasp, transform.position, Quaternion.identity);
                turretDestroyed = true;
            }
        }
    }
}
