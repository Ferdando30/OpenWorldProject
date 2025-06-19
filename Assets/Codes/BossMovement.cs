using UnityEngine;
using System.Collections.Generic;

public class BossMovement : MonoBehaviour
{
     [SerializeField]
    List<Transform> waypoint;

    [SerializeField]
    float movespeed = 2f;

    int waypointIndex = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = waypoint[waypointIndex].position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (waypointIndex <= waypoint.Count - 1)
        {
            var targetPosition = waypoint[waypointIndex].position;
            var moveThisFrame = movespeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(
                transform.position,
                targetPosition,
                moveThisFrame
            );
            if (transform.position == targetPosition)
            {
                waypointIndex++;
            }
            else
            {
                waypointIndex = 0;
            }
        }
    }
}