using UnityEngine;

public class boss1Movement : MonoBehaviour
{
    public float speed;
    public bool inPosition = false;
    public float amplitude;
    public float frequency;
    float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Handle movement
        transform.rotation = Quaternion.Euler(0, 0, 180); // Face downwards
        if (inPosition) // Sine wave movement once in position
        {
            timer += Time.deltaTime;
            float sin = Mathf.Sin(timer * frequency) * amplitude; // Sine wave based on timer
            transform.position = new Vector2(sin, transform.position.y);
        }
        else if (!inPosition) // Move to position
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
            if (transform.position.y <= 3.5f)
            {
                inPosition = true;
                timer = 0f;
            }
        }
    }
}
