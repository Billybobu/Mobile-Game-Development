using UnityEngine;

public class goToStore : MonoBehaviour
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
        PlayerPrefs.SetFloat("autoClickerTimer", mainButton.autoClickerTimer);
        UnityEngine.SceneManagement.SceneManager.LoadScene("StoreScene");
    }
}
