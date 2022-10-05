using UnityEngine;
using UnityEngine.AI;

public class LevelGenerator : MonoBehaviour
{
    public NavMeshSurface surface;

    public int width = 20;
    public int height = 20;

    public GameObject wall;
    public GameObject player;

    private void Start()
    {
        // surface.BuildNavMesh();
    }
}
