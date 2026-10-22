using UnityEngine;
using TMPro;

public class scoreDisplay : MonoBehaviour
{
    public mainButtonScript mainButton;
    public TextMeshProUGUI scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.SetText("Score: {0}", mainButton.score);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.SetText("Score: {0}", mainButton.score);
    }
}
