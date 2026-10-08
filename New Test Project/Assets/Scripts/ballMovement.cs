using UnityEngine;
using UnityEngine.InputSystem;

public class ballMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    [SerializeField] InputActionReference moveAction;

    void OnEnable() => moveAction.action.Enable();
    void OnDisable() => moveAction.action.Disable();
    public Rigidbody2D rb;


    // Update is called once per frame
    void Update()
    {
        Vector2 move = moveAction.action.ReadValue<Vector2>();
        // Pass move to the movement code you already have.
        rb.linearVelocity = new Vector2(move.x * 5f, move.y * 5f);

    }
}
