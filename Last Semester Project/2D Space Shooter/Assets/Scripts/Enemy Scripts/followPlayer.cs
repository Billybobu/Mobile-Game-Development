using UnityEngine;

public class followPlayer : MonoBehaviour
{
    // Reference to the player's transform
    Transform player;
    // Speed at which the enemy follows the player
    public float speed;
    public float rotationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().linearVelocity = transform.up * speed; // Move forward in the direction the enemy is facing
        GameObject go = GameObject.FindGameObjectWithTag("Player"); // Find the player object by its tag
        if (go != null)
        {
            player = go.transform; // Get the player's transform
            Vector3 dir = player.transform.position - transform.position; // Calculate the direction vector to the player
            dir.Normalize(); // Normalize the direction vector
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg; // Calculate the angle to the player in degrees
            Quaternion desiredRotation = Quaternion.Euler(new Vector3(0, 0, angle - 90)); // Create a rotation quaternion towards the player
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, rotationSpeed * Time.deltaTime); // Rotate towards the player smoothly
        }
    }
}
