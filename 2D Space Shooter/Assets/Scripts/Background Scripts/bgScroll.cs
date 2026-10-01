using UnityEngine;

public class bgScroll : MonoBehaviour
{
    // Public variable to control the scroll speed of the background
    public float scrollSpeed;
    [SerializeField]
    private Renderer bgRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bgRenderer.material.mainTextureOffset += new Vector2(0f, scrollSpeed * Time.deltaTime);
    }
}
