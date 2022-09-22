using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRigidbody : MonoBehaviour
{
    public float speed = 10f;
    public float jumpHeight = 3f;
    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        #region jump
        // Force - attaches to mass and fixed step of time
        // Acceleration - attaches only for fixed step of time
        // Impulse - attaches only for mass and don't for time
        // VelocityChange don't attaces for smth
        if (Input.GetKeyDown(KeyCode.Space))
            _rb.AddForce(transform.up * jumpHeight, ForceMode.Impulse);
        #endregion
    }

    private void FixedUpdate()
    {
        var moveX = Input.GetAxis("Horizontal") * speed;
        var moveZ = Input.GetAxis("Vertical")  * speed;

        _rb.velocity += transform.forward * moveZ + transform.right * moveX;

        if (_rb.velocity.x > speed)
            _rb.velocity = transform.forward * speed;

    }
}
