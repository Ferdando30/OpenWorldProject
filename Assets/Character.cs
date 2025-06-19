using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Character : MonoBehaviour
{
    [SerializeField]
    float waitTimeOnWaypoint = 1f;

    [SerializeField]
    Path path;

    NavMeshAgent agent;
    //Animator animator;

    float time = 0f;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent.destination = path.GetCurrentWaypoint();
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance <= 0.1f)
        {
            time += Time.deltaTime;
            if (time >= waitTimeOnWaypoint)
            {
                time = 0f;
                agent.destination = path.GetNextWaypoint();
            }
        }
    }
}
