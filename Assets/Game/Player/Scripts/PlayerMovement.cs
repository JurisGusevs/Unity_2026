using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;
    [SerializeField] private float jumpForce = 8f;
    [SerializeField] private LayerMask jumpableGround;
    private BoxCollider2D playerCollider;
    private Rigidbody2D rb;
    private PlayerInputActions playerInput;

    public bool isPlayerDead = false;

    private void Awake()
    {
        playerInput = new PlayerInputActions();
        playerInput.Movement.Enable();
        playerInput.Movement.Jump.performed += JumpAction;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerCollider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (!isPlayerDead)
        {
            float axis = playerInput.Movement.Horizontal.ReadValue<float>();

            rb.linearVelocity = new Vector2(axis * movementSpeed * Time.deltaTime, rb.linearVelocity.y);
        } else
        {
            rb.bodyType = RigidbodyType2D.Kinematic;
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(playerCollider.bounds.center, playerCollider.bounds.size, 0f, Vector2.down, 0.1f, jumpableGround);
    }

    private void JumpAction(InputAction.CallbackContext context)
    {
        if (IsGrounded() && !isPlayerDead)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
