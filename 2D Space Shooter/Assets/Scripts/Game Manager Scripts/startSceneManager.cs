using UnityEngine;
using TMPro;

public class startSceneManager : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("highScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
