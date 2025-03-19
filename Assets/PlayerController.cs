using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float movementSpeed;
    private Rigidbody2D _rb;
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        HandlePlayerMovement();
    }

    private void HandlePlayerMovement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        movement = Vector2.ClampMagnitude(movement, 1.0f);
        _rb.linearVelocity = movement * movementSpeed;
    }
}
