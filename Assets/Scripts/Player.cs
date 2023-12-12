using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public GameObject target1, target2, target3;

    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = target1.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Target1")
        {
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            agent.destination = target2.transform.position;
        }
        if (other.tag == "Target2")
        {
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            agent.destination = target3.transform.position;
        }
        if (other.tag == "Target3")
        {
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            agent.destination = target1.transform.position;
        }
    }
}
