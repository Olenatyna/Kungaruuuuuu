using UnityEngine;
using UnityEngine.AI;

public class BotBotBot : MonoBehaviour
{
    private GameObject target;
    private NavMeshAgent agent;
    [SerializeField] int distace;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player");
       
    }

    void FixedUpdate()
    {
        if (Vector3.Distance(target.transform.position, transform.position) < distace)
        {
            agent.destination = target.transform.position;
            transform.LookAt(target.transform.position);
        }
        
    }
}
