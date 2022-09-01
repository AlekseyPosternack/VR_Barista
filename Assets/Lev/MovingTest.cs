using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTest : MonoBehaviour
{
    public Transform playerTransform;
   
    void Start()
    {
        playerTransform = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        
        float distance = Vector3.Distance(playerTransform.position, transform.position);
        Debug.Log(distance);
        if (distance <= 1f)
        {
            transform.Rotate(0, 60, 0);
        }
        
    }


}
