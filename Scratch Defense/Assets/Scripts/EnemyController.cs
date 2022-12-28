using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //[SerializeField]
    //private Transform[] waypoints;
    //private float moveSpeed = 2f;

    [SerializeField]
    private GameObject waypointPrefab;

    private GameObject[] pathItems;
    private GameObject[] waypoints;
    //private int waypointIndex = 0;

    private void Start()
    {
        
    }
    void Update()
    {
        MarkPositions();
        //Move();
    }
    //private void Move()
    //{
    //    if (waypointIndex <= waypoints.Length - 1)
    //    {
    //        transform.position = Vector2.MoveTowards(transform.position,
    //           waypoints[waypointIndex].transform.position,
    //           moveSpeed * Time.deltaTime);


    //        if (transform.position == waypoints[waypointIndex].transform.position)
    //        {
    //            waypointIndex += 1;
    //        }
    //    }
    //}

    void MarkPositions()
    {
        pathItems = GameObject.FindGameObjectsWithTag("Path");
        waypoints = GameObject.FindGameObjectsWithTag("Waypoint");
        GameObject wp;
        foreach (GameObject obj in pathItems)
        {
            if(waypoints.Length<253) //make a const with tile list(create one) length
            {
                wp = Instantiate(waypointPrefab, obj.transform.position, Quaternion.identity);
                wp.transform.parent = gameObject.transform;
            }
            
        }
    }

    void FollowPath(Array paths)
    {
        float distance;
        foreach(Transform pathTransform in paths)
        {
            distance = Vector2.Distance(transform.position, pathTransform.position);
        }
    }
}


