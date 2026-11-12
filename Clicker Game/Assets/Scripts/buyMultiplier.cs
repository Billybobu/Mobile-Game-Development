using UnityEngine;

public class buyMultiplier : MonoBehaviour
{
    public mainButtonScript mainButton;
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
        if (mainButton.score >= 40)
        {
            mainButton.score -= 40;
            mainButton.scoreMultiplier = 2;
            Debug.Log("Score multiplier purchased! Current multiplier: " + mainButton.scoreMultiplier);
        }
        else
        {
            Debug.Log("Not enough score to purchase a score multiplier.");
        }
    }
}
