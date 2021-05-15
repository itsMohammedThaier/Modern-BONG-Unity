using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    private float movement;
    private Rigidbody2D playerRb;
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        UpdateMovementInput();
        Move();
    }

    private void UpdateMovementInput()
    {
        if(isPlayer1)
        {
            movement = Input.GetAxis("Vertical1");
            return;
        }
        movement = Input.GetAxis("Vertical2");
    }

    private void Move()
    {
        playerRb.velocity = new Vector2(0, movement * speed);
    }
}
