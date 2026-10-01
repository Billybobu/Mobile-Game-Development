using UnityEngine;

public class turretShoot : MonoBehaviour
{
    public GameObject gun1;
    public GameObject gun2;
    public GameObject gun3;
    public float minFireDelay;
    public float maxFireDelay;
    float fireTimer;
    public float rotateSpeed;
    Transform player;
    public AudioSource audioSource;
    public AudioClip shootSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fireTimer -= Time.deltaTime; // Decrease the fire timer by the time elapsed since the last frame
        GameObject go = GameObject.FindGameObjectWithTag("Player"); // Find the player object by its tag
        if (go != null)
        {
            player = go.transform; // Get the player's transform
            Vector3 dir = player.transform.position - transform.position; // Calculate the direction vector to the player
            dir.Normalize(); // Normalize the direction vector
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg; // Calculate the angle to the player in degrees
            Quaternion desiredRotation = Quaternion.Euler(new Vector3(0, 0, angle - 90)); // Create a rotation quaternion towards the player
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, rotateSpeed * Time.deltaTime); // Rotate towards the player smoothly
        }
        if (fireTimer <= 0)
        {
            Vector2 position = transform.position;
            // Check if turret is on screen
            if (position.x > -9 && position.x < 9 && position.y > -5 && position.y < 5) 
            {
                Shoot();
                fireTimer = Random.Range(minFireDelay, maxFireDelay + 1);
            }
        }
    }

    public void Shoot()
    {
        audioSource.PlayOneShot(shootSound);
        gun1.GetComponent<droneGun>().Shoot();
        gun2.GetComponent<droneGun>().Shoot();
        gun3.GetComponent<droneGun>().Shoot();
    }

    void Awake()
    {
        fireTimer = Random.Range(minFireDelay, maxFireDelay + 1);
    }
}
