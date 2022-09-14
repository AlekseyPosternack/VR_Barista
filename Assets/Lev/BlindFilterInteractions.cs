using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlindFilterInteractions : MonoBehaviour
{
    public MeshRenderer filterRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision collision)
    {
        // foreach (ContactPoint contact in collision.contacts)
        // {
        //     Debug.DrawRay(contact.point, contact.normal, Color.white);
        // }

        if (collision.gameObject.CompareTag("ChemsParts"))
        {
            filterRenderer.material.color = Color.cyan;
            Debug.Log("filter-> collision chems");
            
        }
        else if(collision.gameObject.CompareTag("WaterFall"))
        {
            filterRenderer.material.color = Color.white;
            Debug.Log("filter-> collision waterfall");
        }
        else
        {
            Debug.Log("collision not done");
        }
    }
}
