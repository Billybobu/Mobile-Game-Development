using UnityEngine;

public class scoreController : MonoBehaviour
{
    // Score variable
    public int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = PlayerPrefs.GetInt("finalScore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Method to add score
    public void AddScore(int amount)
    {
        score += amount;
    }
}
