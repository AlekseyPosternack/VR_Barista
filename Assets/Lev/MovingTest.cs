using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTest : MonoBehaviour
{
    public Transform playerTransform;
    public Transform filterTransform;
    public  float distanceToFilter;
   
    void Start()
    {
        playerTransform = GameObject.FindWithTag("Player").transform;
        filterTransform = GameObject.FindWithTag("BlindFilter").transform;
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(playerTransform.position, transform.position);
        // Debug.Log(distanceToPlayer);
        if (distanceToPlayer <= 1f)
        {
            transform.Rotate(0, 60, 0);
        }
        
        distanceToFilter = Vector3.Distance(filterTransform.position, transform.position);
        if (distanceToFilter <= 0.1f)
        {
            addBlindFilter(transform, filterTransform);
        }
    }

    void addBlindFilter(Transform leverTransform, Transform filterTransform)
    {
        filterTransform.parent = leverTransform.parent;
        
        Debug.Log("addBlindFilter DONE ");
    }

}
