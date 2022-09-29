using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float sprintSpeed = 10f;
    public float jumpHeight = 3f;
    public float heightInSitPosition = 1f;
    public float gravity = -9.81f;
    public float groundDistance = 0.4f;
    public CharacterController controller;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private Vector3 _velocity;
    private bool _isGrounded;
    private float _startSpeed;
    private float _characterHeight;

    private void Start()
    {
        _startSpeed = speed;
        _characterHeight = controller.height;
    }

    private void Update()
    {
        Move();
        Sprint();
        Sit();
        Jump();
        Falling();
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Water"))
        {
            if(Input.GetKey(KeyCode.Space))
            {
                _velocity.y += 0.3f;
            }
        }
    }

    private void Move()
    {
        // inputs
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // player movement
        Vector3 moveDirection = transform.right * moveX + transform.forward * moveY;
        controller.Move(moveDirection * speed * Time.deltaTime);
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && _isGrounded)
        {
            _velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
    }

    private void Sit()
    {
        if (Input.GetKey("c"))
        {
            controller.height = Mathf.Lerp(controller.height, heightInSitPosition, Time.deltaTime * 10f);
        }
        else
        {
            controller.height = Mathf.Lerp(controller.height, _characterHeight, Time.deltaTime * 10f); ;
        }
    }

    private void Sprint()
    {
        if (Input.GetKey(KeyCode.LeftShift) && _isGrounded)
        {
            speed = Mathf.Lerp(speed, sprintSpeed, Time.deltaTime * 10f);
        }
        else
        {
            speed = Mathf.Clamp(speed - Time.deltaTime * 5f, _startSpeed, sprintSpeed);
        }
    }

    private void Falling()
    {
        _isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundLayer);

        if (_isGrounded && _velocity.y < 0)
        {
            _velocity.y = -2f;
        }

        _velocity.y += gravity * Time.deltaTime;
        controller.Move(_velocity * Time.deltaTime);
    }
}
