using UnityEngine;

public class MovementController : MonoBehaviour
{
    [Range(0f, 5f)]
    public float speed = 3f;

    private Animator _animator;
    private float _verticalMovement;
    private float _horizontalMovement;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _verticalMovement = Input.GetAxis("Vertical");
        _horizontalMovement = Input.GetAxis("Horizontal");

        _animator.SetFloat("movementSpeed", _verticalMovement);
    }
}
