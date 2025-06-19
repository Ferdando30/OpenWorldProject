using UnityEngine;

public class Path : MonoBehaviour
{
    public enum PathType
    {
        Loop,
        ReverseWhenComplete
    }

    public Transform[] waypoints;
    public PathType pathType = PathType.Loop;

    public int direction = 1;
    public int index;

    public Vector3 GetCurrentWaypoint()
    {
        return waypoints[index].position;
    }

    public Vector3 GetNextWaypoint()
    {
        if (waypoints.Length == 0) return transform.position;

        index = GetNextWaypointIndex();
        Vector3 nextWayPoint = waypoints[index].position;

        return nextWayPoint;
    }

    private int GetNextWaypointIndex()
    {
        index += direction;

        if (pathType == PathType.Loop)
        {
            index %= waypoints.Length;
            if (index <= 0)
            {
                index = waypoints.Length;
            }
            else if (index >= waypoints.Length)
            {
                index = 0;
            }
        }
        else if (pathType == PathType.ReverseWhenComplete)
        {
            if (index >= waypoints.Length || index < 0)
            {
                direction *= -1;
                index = +direction + 2;
            }
        }
        return index;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
