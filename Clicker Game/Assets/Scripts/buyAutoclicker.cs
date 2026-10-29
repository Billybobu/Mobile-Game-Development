using UnityEngine;

public class buyAutoclicker : MonoBehaviour
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
        if (mainButton.score >= 25)
        {
            mainButton.score -= 25;
            mainButton.autoClickerAmount += 1;
            Debug.Log("Autoclicker purchased! Total autoclickers: " + mainButton.autoClickerAmount);
        }
        else
        {
            Debug.Log("Not enough score to purchase an autoclicker.");
        }
    }
}
