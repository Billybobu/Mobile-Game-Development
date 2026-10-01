using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToLevelOne()
    {
        PlayerPrefs.SetInt("finalScore", 0);
        SceneManager.LoadScene("level1Scene");
    }
}
