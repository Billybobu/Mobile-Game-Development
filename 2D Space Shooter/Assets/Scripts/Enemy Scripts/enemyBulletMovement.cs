using UnityEngine;

public class enemyBulletMovement : MonoBehaviour
{
    public float bulletSpeed;
    public GameObject hitExplosion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Set the projectile's velocity when it is created
    private void Awake()
    {
        GetComponent<Rigidbody2D>().linearVelocity = transform.up * bulletSpeed;
    }

    // Spawns an explosion effect upon collision
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            Instantiate (hitExplosion, transform.position, transform.rotation);
    }

    // Destroy the projectile when it goes off-screen
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
