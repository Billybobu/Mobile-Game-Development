using UnityEngine;

public class downwardsSineWave : MonoBehaviour
{
    // Movement variables
    float sinCentreX;
    public float enemySpeed;
    public float amplitude;
    public float frequency;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Handle sine wave movement
        transform.rotation = Quaternion.Euler(0, 0, 180);
        GetComponent<Rigidbody2D>().linearVelocityY = -enemySpeed; // Move downwards
        Vector2 enemyPosition = transform.position;
        float sin = Mathf.Sin(enemyPosition.y * frequency) * amplitude; // Sine wave based on Y position
        float newX = sin + sinCentreX; // New X position based on sine wave
        transform.position = new Vector2(newX, enemyPosition.y);
    }

    // Set the sine wave center when the enemy is created
    void Awake()
    {
        sinCentreX = transform.position.x;
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
