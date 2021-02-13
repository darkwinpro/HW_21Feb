
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    [SerializeField] 
    private Transform[] points;

    private int _destinationPoint = 0;
    private NavMeshAgent _myAgent;
    
    void Start()
    {
        _myAgent = GetComponent<NavMeshAgent>();
        _myAgent.autoBraking = false;
        GoToNextPoint();
    }

    void GoToNextPoint()
    {
        if (points.Length == 0)
            return;
        _myAgent.destination = points[_destinationPoint].position;
        _destinationPoint = (_destinationPoint + 1) % points.Length;
    }
    
    void Update()
    {
        if (!_myAgent.pathPending && _myAgent.remainingDistance < _myAgent.stoppingDistance)
            GoToNextPoint();
    }
}
