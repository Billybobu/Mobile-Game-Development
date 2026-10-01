using UnityEngine;

public class enemyScoreAllocator : MonoBehaviour
{
    // Score given to player upon enemy kill
    [SerializeField]
    private int killScore;

    // Reference to scoreController
    private scoreController scoreController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        scoreController = FindFirstObjectByType<scoreController>();

    }
    public void AllocateScore()
    {
        scoreController.AddScore(killScore);
    }
}
