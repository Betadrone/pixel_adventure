using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.UIElements;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField]
    private GameObject[] waypoints;
    private int currentWaypointIndex = 0;

    [SerializeField] private float speed = 2.0f;

    private void Update()
    {
        FollowWaypoint();
    }

    private void FollowWaypoint()
    {
        Vector2 waypointPosition = waypoints[currentWaypointIndex].transform.position;
        Vector2 followerPosition = transform.position;
        
        if (Vector2.Distance(waypointPosition, followerPosition) < 0.1f)
        {
            currentWaypointIndex++;
            if(currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
        
        transform.position = Vector2.MoveTowards(followerPosition, waypointPosition, Time.deltaTime * speed);
    }
}
