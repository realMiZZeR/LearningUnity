using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPerson : MonoBehaviour
{
    public float movementSpeed;
    public float jumpHeight;

    [SerializeField] private Transform _cameraPosition;
    [SerializeField] private LayerMask _groundLayer;

    private Animator _animator;
    private CharacterController _character;
    private float _horizontalAxis;
    private float _verticalAxis;
    private float gravity = -9.81f;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _character = GetComponent<CharacterController>();
    }

    void Update()
    {
        _animator.SetFloat("horizontal", _horizontalAxis);
        _animator.SetFloat("vertical", _verticalAxis);
    }

    private void FixedUpdate()
    {
        _horizontalAxis = Input.GetAxis("Horizontal");
        _verticalAxis = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(_horizontalAxis, _character.transform.position.y, _verticalAxis);
        Vector3 distance = move * Time.fixedDeltaTime * movementSpeed;
        _character.Move(distance);
        _cameraPosition.transform.position += distance;
    }

    private bool CheckIfGrounded()
    {
        return true;
    }
}
