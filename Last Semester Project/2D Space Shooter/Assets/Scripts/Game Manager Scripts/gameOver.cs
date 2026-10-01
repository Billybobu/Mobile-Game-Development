using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    bool gameIsOver = false;
    float timer = 2f;
    public scoreController scoreController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameIsOver == true)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                PlayerPrefs.SetInt("finalScore", scoreController.score);
                SceneManager.LoadScene("gameOverScene");
            }
        }
    }

    public void playerDead() 
    {
        gameIsOver = true;
    }
}
