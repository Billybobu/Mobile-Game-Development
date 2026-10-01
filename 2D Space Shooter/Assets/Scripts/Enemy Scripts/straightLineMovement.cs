using UnityEngine;

public class straightLineMovement : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Set the enemy's velocity when it is created
    private void Awake()
    {
        GetComponent<Rigidbody2D>().linearVelocity = transform.up * speed;
    }

    // Destroy the projectile when it goes off-screen
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
