using UnityEngine;

public class mainButtonScript : MonoBehaviour
{
    public int score = 0;
    public int scoreIncrement = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClick()
    {
        score += scoreIncrement;
        Debug.Log("Score: " + score);
    }
}
