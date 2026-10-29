using UnityEngine;

public class mainButtonScript : MonoBehaviour
{
    public int score = 0;
    public int scoreIncrement = 1;
    public int autoClickerAmount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = PlayerPrefs.GetInt("score", 0);
    }

    // Update is called once per frame
    void Update()
    {
        score += autoClickerAmount;
    }

    public void OnButtonClick()
    {
        score += scoreIncrement;
        Debug.Log("Score: " + score);
    }
}
