using UnityEngine;

public class Water : MonoBehaviour
{
    public float repulsiveForce;
    public Color wetColor;

    private Color _enterColor;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<Renderer>(out Renderer renderer))
        {
            _enterColor = renderer.material.color;
            Soak(renderer);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody == null) return;

        other.attachedRigidbody.AddForce(Vector3.up * repulsiveForce);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<Renderer>(out Renderer renderer))
        {
            // Dry(renderer);
        }
    }

    private void Soak(Renderer renderer)
    {
        if(renderer)
        {
            renderer.material.color = wetColor;
        }
        
    }

    private void Dry(Renderer renderer)
    {
        if(renderer)
        {
            renderer.material.color = _enterColor;
        }
    }
}
