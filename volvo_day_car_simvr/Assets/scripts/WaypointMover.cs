using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMover : MonoBehaviour
{
    [SerializeField] private Waypoints waypoints;
    [SerializeField] private float moveSpeed = 20f;
    [SerializeField] private float rotationSpeed = 5f;
    [SerializeField] private float distanceThreshold = 0.1f;
    public int index;
    private Transform currentWaypoint;

    // Start is called before the first frame update
    void Start()
    {
        currentWaypoint = waypoints.Spawn(currentWaypoint, index);
        transform.position = currentWaypoint.position;
        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the direction to the current waypoint
        Vector3 targetDirection = currentWaypoint.position - transform.position;

        // Calculate the angle between the Z-axis and the target direction
        float targetZRotation = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;

        // Create the target rotation around the Z-axis
        Quaternion targetRotation = Quaternion.Euler(0f, 0f, targetZRotation);

        // Smoothly rotate the player towards the waypoint direction
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        // Move the player towards the waypoint
        transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, moveSpeed * Time.deltaTime);

        // Check if the player has reached the waypoint
        if (Vector3.Distance(transform.position, currentWaypoint.position) < distanceThreshold)
        {
            currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        }
    }
}
