using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class uiManager : MonoBehaviour
{
    // Health UI Sprites and Images
    public Sprite fullHeart;
    public Sprite halfHeart;
    public Sprite emptyHeart;
    public Image heart1;
    public Image heart2;
    public Image heart3;
    public Image heart4;
    public Image heart5;
    // Reference to Player Health Script - Player in scene needs to be assigned manually otherwise it will not work
    public playerHealth playerHealth;
    // Reference to Score Text and Score Controller
    public TMP_Text scoreText;
    public scoreController scoreController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Update Score UI
        scoreText.text = "Score: " + scoreController.score.ToString();
        // Update Health UI based on current health
        if (playerHealth.currentHealth == 10)
        {
            heart1.sprite = fullHeart;
            heart2.sprite = fullHeart;
            heart3.sprite = fullHeart;
            heart4.sprite = fullHeart;
            heart5.sprite = fullHeart;
        }
        else if (playerHealth.currentHealth == 9)
        {
            heart1.sprite = fullHeart;
            heart2.sprite = fullHeart;
            heart3.sprite = fullHeart;
            heart4.sprite = fullHeart;
            heart5.sprite = halfHeart;
        }
        else if (playerHealth.currentHealth == 8)
        {
            heart1.sprite = fullHeart;
            heart2.sprite = fullHeart;
            heart3.sprite = fullHeart;
            heart4.sprite = fullHeart;
            heart5.sprite = emptyHeart;
        }
        else if (playerHealth.currentHealth == 7)
        {
            heart1.sprite = fullHeart;
            heart2.sprite = fullHeart;
            heart3.sprite = fullHeart;
            heart4.sprite = halfHeart;
            heart5.sprite = emptyHeart;
        }
        else if (playerHealth.currentHealth == 6)
        {
            heart1.sprite = fullHeart;
            heart2.sprite = fullHeart;
            heart3.sprite = fullHeart;
            heart4.sprite = emptyHeart;
            heart5.sprite = emptyHeart;
        }
        else if (playerHealth.currentHealth == 5)
        {
            heart1.sprite = fullHeart;
            heart2.sprite = fullHeart;
            heart3.sprite = halfHeart;
            heart4.sprite = emptyHeart;
            heart5.sprite = emptyHeart;
        }
        else if (playerHealth.currentHealth == 4)
        {
            heart1.sprite = fullHeart;
            heart2.sprite = fullHeart;
            heart3.sprite = emptyHeart;
            heart4.sprite = emptyHeart;
            heart5.sprite = emptyHeart;
        }
        else if (playerHealth.currentHealth == 3)
        {
            heart1.sprite = fullHeart;
            heart2.sprite = halfHeart;
            heart3.sprite = emptyHeart;
            heart4.sprite = emptyHeart;
            heart5.sprite = emptyHeart;
        }
        else if (playerHealth.currentHealth == 2)
        {
            heart1.sprite = fullHeart;
            heart2.sprite = emptyHeart;
            heart3.sprite = emptyHeart;
            heart4.sprite = emptyHeart;
            heart5.sprite = emptyHeart;
        }
        else if (playerHealth.currentHealth == 1)
        {
            heart1.sprite = halfHeart;
            heart2.sprite = emptyHeart;
            heart3.sprite = emptyHeart;
            heart4.sprite = emptyHeart;
            heart5.sprite = emptyHeart;
        }
        else if (playerHealth.currentHealth == 0)
        {
            heart1.sprite = emptyHeart;
            heart2.sprite = emptyHeart;
            heart3.sprite = emptyHeart;
            heart4.sprite = emptyHeart;
            heart5.sprite = emptyHeart;
        }
    }
}
