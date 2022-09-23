using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtFalling : MonoBehaviour
{
    [SerializeField] private AudioSource _hurtSound;

    private void OnCollisionEnter(Collision collision)
    {
        _hurtSound.volume = collision.impulse.magnitude * 0.01f;
        _hurtSound.Play();
    }
}
