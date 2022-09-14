using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFallInteractions : MonoBehaviour
{
    public Transform waterPointTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = waterPointTransform.position;
    }
}
