using UnityEngine;
using TMPro;

public class finalScoreManager : MonoBehaviour
{
    public TextMeshProUGUI finalScoreText;
    public TextMeshProUGUI newHighScoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        finalScoreText.text = "Score: " + PlayerPrefs.GetInt("finalScore").ToString();
        if (PlayerPrefs.GetInt("finalScore") > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", PlayerPrefs.GetInt("finalScore"));
            newHighScoreText.gameObject.SetActive(true);
        }
        else
        {
            newHighScoreText.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
