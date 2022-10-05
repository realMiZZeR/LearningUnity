using UnityEngine;
using UnityEngine.AI;

public class NavMeshPlayerController : MonoBehaviour
{
    private Camera _camera;
    private NavMeshAgent _agent;

    private void Start()
    {
        _camera = Camera.main;
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(_camera.ScreenPointToRay(Input.mousePosition), out RaycastHit clickHit))
            {
                _agent.SetDestination(clickHit.point);
            }
        }
    }
}
