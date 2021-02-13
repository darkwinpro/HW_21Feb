
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    private Transform _pointer;
    [SerializeField]
    private AudioSource _click;
    [SerializeField]
    private UnityEngine.AI.NavMeshAgent _myAgent;
    
    void Start()
    {
        _myAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    private void LateUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if (Physics.Raycast(ray, out hit))
        {
            _pointer.position = hit.point;
            if (Input.GetMouseButtonDown(0))
            {
                _myAgent.SetDestination(hit.point);
                _click.Play();
                Debug.Log("Come here!!!");
            }
        }
    }
}
