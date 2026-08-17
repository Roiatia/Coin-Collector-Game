using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpSpeed = 12f;
    [SerializeField] private LayerMask groundLayer;

    private Rigidbody2D rb2d;
    private float horizontalInput;
    private bool isGrounded;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontalInput = 0f;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            horizontalInput = -1f;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            horizontalInput = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb2d.linearVelocity = new Vector2(rb2d.linearVelocity.x, jumpSpeed);
            isGrounded = false;
        }
    }

    void FixedUpdate()
    {
        rb2d.linearVelocity = new Vector2(horizontalInput * moveSpeed, rb2d.linearVelocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (IsGroundLayer(collision.gameObject))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (IsGroundLayer(collision.gameObject))
        {
            isGrounded = true;
        }
    }

    private bool IsGroundLayer(GameObject checkedObject)
    {
        return (groundLayer.value & (1 << checkedObject.layer)) != 0;
    }
}