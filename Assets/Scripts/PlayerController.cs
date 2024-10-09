using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    private Vector3 _movementDir;
    private bool _grounded;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        _movementDir = new Vector3(horizontalInput, 0f, 0f);
    }

    private void FixedUpdate()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        _rb.AddForce(_movementDir * (speed * 10 * Time.deltaTime));
    }

    private void HandleJump()
    {
        _rb.AddForce(new Vector3(0f, jumpForce, 0f), ForceMode.Impulse);
    }
}
