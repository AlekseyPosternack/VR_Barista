using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChemsInteractions : MonoBehaviour
{
    public Transform chemsCentreTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = chemsCentreTransform.position;
    }
}
