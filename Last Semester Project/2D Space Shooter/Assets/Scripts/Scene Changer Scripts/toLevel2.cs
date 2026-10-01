using UnityEngine;
using UnityEngine.SceneManagement;

public class toLevel2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToLevelTwo()
    {
        SceneManager.LoadScene("level2Scene");
    }
}
