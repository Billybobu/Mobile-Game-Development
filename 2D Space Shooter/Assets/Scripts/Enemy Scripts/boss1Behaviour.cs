using UnityEngine;
using System.Collections;

public class boss1Behaviour : MonoBehaviour
{
    // Boss health
    int health;
    public int maxHealth;
    public enemyDeathScript enemyDeathScript;
    // Boss guns
    public GameObject mainGun1;
    public GameObject mainGun2;
    public GameObject secondaryGun1;
    public GameObject secondaryGun2;
    public GameObject secondaryGun3;
    public GameObject secondaryGun4;
    public GameObject secondaryGun5;
    public GameObject secondaryGun6;
    public GameObject secondaryGun7;
    public GameObject secondaryGun8;
    public GameObject missileLauncher1;
    public GameObject missileLauncher2;
    // Firing
    public float fireDelay;
    float fireTimer;
    public float missileDelay = 5f;
    float missileTimer;
    // Audio
    public AudioSource audioSource;
    public AudioClip shootSound;
    public boss1Movement boss1Movement;
    // Phase control
    bool secondPhase = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Awake()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        // Handle firing patterns
        if (boss1Movement.inPosition == true) // Only fire when in position
        {
            fireTimer -= Time.deltaTime;
            missileTimer -= Time.deltaTime;
            if (fireTimer <= 0)
            {
                int pattern = Random.Range(1, 5); // Randomly choose between 1 and 4
                if (pattern == 1)
                {
                    StartCoroutine(AttackPattern1());
                }
                else if (pattern == 2)
                {
                    AttackPattern2();
                }
                else if (pattern == 3)
                {
                    StartCoroutine(AttackPattern3());
                }
                else if (pattern == 4)
                {
                    AttackPattern4();
                }
                fireTimer = fireDelay;
            }
            if (missileTimer <= 0 && secondPhase)
            {
                LaunchMissiles();
                missileTimer = missileDelay;
            }
        }
    }

    // Handles collision with player bullets
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerBullet"))
        {
            health -= 1;
            Destroy(other.gameObject);
            if (health <= maxHealth / 2 && secondPhase == false)
            {
                // Enter second phase
                PhaseTwo();
            }
            else if (health <= 0)
            {
                enemyDeathScript.Die();
            }
        }
        if (other.CompareTag("DoubleDamageBullet"))
        {
            health -= 2;
            Destroy(other.gameObject);
            if (health <= maxHealth / 2 && secondPhase == false)
            {
                // Enter second phase
                PhaseTwo();
            }
            else if (health <= 0)
            {
                enemyDeathScript.Die();
            }
        }
    }

    // Attack pattern 1: Fire main guns 3 times with 0.2 second delay
    IEnumerator AttackPattern1()
    {
        int shotsFired = 0;
        while (shotsFired < 3) 
        {
            audioSource.PlayOneShot(shootSound);
            mainGun1.GetComponent<droneGun>().Shoot();
            mainGun2.GetComponent<droneGun>().Shoot();
            shotsFired++;
            yield return new WaitForSeconds(0.2f);
        }
    }

    // Attack pattern 2: Fire all secondary guns once
    void AttackPattern2()
    {
        audioSource.PlayOneShot(shootSound);
        secondaryGun1.GetComponent<droneGun>().Shoot();
        secondaryGun2.GetComponent<droneGun>().Shoot();
        secondaryGun3.GetComponent<droneGun>().Shoot();
        secondaryGun4.GetComponent<droneGun>().Shoot();
        secondaryGun5.GetComponent<droneGun>().Shoot();
        secondaryGun6.GetComponent<droneGun>().Shoot();
        secondaryGun7.GetComponent<droneGun>().Shoot();
        secondaryGun8.GetComponent<droneGun>().Shoot();
    }

    IEnumerator AttackPattern3()
    {
        int shotsFired = 0;
        while (shotsFired < 2) 
        {
            audioSource.PlayOneShot(shootSound);
            mainGun1.GetComponent<droneGun>().QuadShot();
            mainGun2.GetComponent<droneGun>().QuadShot();
            shotsFired++;
            yield return new WaitForSeconds(0.5f);
        }
    }

    void AttackPattern4()
    {
        audioSource.PlayOneShot(shootSound);
        secondaryGun2.GetComponent<droneGun>().QuadShot();
        secondaryGun6.GetComponent<droneGun>().QuadShot();
        secondaryGun4.GetComponent<droneGun>().QuadShot();
        secondaryGun8.GetComponent<droneGun>().QuadShot();
    }

    void LaunchMissiles()
    {
        missileLauncher1.GetComponent<missileLauncher>().Fire();
        missileLauncher2.GetComponent<missileLauncher>().Fire();
    }

    void PhaseTwo() 
    {
        // Adjust firing delay for increased difficulty
        fireDelay *= 0.8f; // Fire 20% faster
        secondPhase = true;
    }
}
