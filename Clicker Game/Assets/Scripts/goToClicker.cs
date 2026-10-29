using UnityEngine;

public class goToClicker : MonoBehaviour
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
        PlayerPrefs.SetInt("score", mainButton.score);
        PlayerPrefs.SetInt("autoClickerAmount", mainButton.autoClickerAmount);
        UnityEngine.SceneManagement.SceneManager.LoadScene("ClickerScene");
    }
}
