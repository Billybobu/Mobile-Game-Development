using UnityEngine;

public class missileLauncher : MonoBehaviour
{
    public GameObject enemyMissile;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Method to launch a missile
    public void Fire()
    {
        Instantiate (enemyMissile, transform.position, transform.rotation);
    }
}
