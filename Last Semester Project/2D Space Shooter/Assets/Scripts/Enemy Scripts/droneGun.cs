using UnityEngine;

public class droneGun : MonoBehaviour
{
    public GameObject enemyBullet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Method to shoot a bullet
    public void Shoot()
    {
        Instantiate (enemyBullet, transform.position, transform.rotation);
    }

    public void QuadShot() 
    {
        // Shoot 4 bullets in a spread pattern - only shoots at set angles downwards so only works for downward facing guns
        float angleStep = 10f;
        float startingAngle = 165f;
        for (int i = 0; i < 4; i++) 
        {
            float currentAngle = startingAngle + (angleStep * i);
            Quaternion rotation = Quaternion.Euler(0, 0, currentAngle);
            Instantiate(enemyBullet, transform.position, rotation);
        }
    }
}
