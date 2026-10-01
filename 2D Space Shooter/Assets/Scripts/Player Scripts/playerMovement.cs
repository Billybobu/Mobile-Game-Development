using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Handles diagonal and multiple key presses for movement
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody2D>().linearVelocityX = 0f;
            GetComponent<Rigidbody2D>().linearVelocityY = 0f;
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().linearVelocityX = 0f;
            GetComponent<Rigidbody2D>().linearVelocityY = moveSpeed;
        }
        else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody2D>().linearVelocityX = 0f;
            GetComponent<Rigidbody2D>().linearVelocityY = -moveSpeed;
        }
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().linearVelocityY = 0f;
            GetComponent<Rigidbody2D>().linearVelocityX = moveSpeed;
        }
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().linearVelocityY = 0f;
            GetComponent<Rigidbody2D>().linearVelocityX = -moveSpeed;
        }
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody2D>().linearVelocityY = 0f;
            GetComponent<Rigidbody2D>().linearVelocityX = 0f;
        }
        else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().linearVelocityX = 0f;
            GetComponent<Rigidbody2D>().linearVelocityY = 0f;
        }
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().linearVelocityY = moveSpeed * 0.7071f; // Approximation of 1/sqrt(2) allows for diagonal movement at same speed as cardinal directions
            GetComponent<Rigidbody2D>().linearVelocityX = -moveSpeed * 0.7071f;
        }
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().linearVelocityY = moveSpeed * 0.7071f;
            GetComponent<Rigidbody2D>().linearVelocityX = moveSpeed * 0.7071f;
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().linearVelocityY = -moveSpeed * 0.7071f;
            GetComponent<Rigidbody2D>().linearVelocityX = -moveSpeed * 0.7071f;
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().linearVelocityY = -moveSpeed * 0.7071f;
            GetComponent<Rigidbody2D>().linearVelocityX = moveSpeed * 0.7071f;
        }
        // Handles single key presses for movement
        else if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().linearVelocityY = moveSpeed;
            GetComponent<Rigidbody2D>().linearVelocityX = 0f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody2D>().linearVelocityY = -moveSpeed;
            GetComponent<Rigidbody2D>().linearVelocityX = 0f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().linearVelocityX = -moveSpeed;
            GetComponent<Rigidbody2D>().linearVelocityY = 0f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().linearVelocityX = moveSpeed;
            GetComponent<Rigidbody2D>().linearVelocityY = 0f;
        }
        else
        {
            GetComponent<Rigidbody2D>().linearVelocityX = 0f;
            GetComponent<Rigidbody2D>().linearVelocityY = 0f;
        }

        // Prevents the player from leaving the screen
        if (transform.position.x >= 8.5f)
        {
            Vector3 pos = transform.position;
            pos.x = 8.5f;
            transform.position = pos;
        }

        if (transform.position.x <= -8.5f)
        {
            Vector3 pos = transform.position;
            pos.x = -8.5f;
            transform.position = pos;
        }

        if (transform.position.y >= 4.5f)
        {
            Vector3 pos = transform.position;
            pos.y = 4.5f;
            transform.position = pos;
        }

        if (transform.position.y <= -4.5f)
        {
            Vector3 pos = transform.position;
            pos.y = -4.5f;
            transform.position = pos;
        }
    }
}
