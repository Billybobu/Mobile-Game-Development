using UnityEngine;

public class mainButtonScript : MonoBehaviour
{
    public int score = 0;
    public int scoreIncrement = 1;
    public int autoClickerAmount = 0;
    public float autoClickerInterval = 10.0f; // Interval in seconds for auto-clicker
    private float autoClickerTimer = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = PlayerPrefs.GetInt("score", 0);
        autoClickerAmount = PlayerPrefs.GetInt("autoClickerAmount", 0);
    }

    // Update is called once per frame
    void Update()
    {
        autoClickerTimer += Time.deltaTime;
        if (autoClickerTimer >= autoClickerInterval)
        {
            autoClickerTimer = 0.0f;
            score += autoClickerAmount;
        }
    }

    public void OnButtonClick()
    {
        score += scoreIncrement;
        Debug.Log("Score: " + score);
    }
}
