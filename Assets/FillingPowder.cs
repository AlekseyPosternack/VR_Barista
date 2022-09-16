using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillingPowder : MonoBehaviour
{
    public GameObject particle;
    public double filling = 0.526;
    private bool collide = false;
    public GameObject leverfil;

    private void Awake()
    {
        particle.GetComponent<ParticleSystem>().Stop();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "lever")
        {
            collide = true;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "lever")
        {
            collide = false;
        }
    }


    public void Fill()
    {

        if (collide)
            {
                
                particle.GetComponent<ParticleSystem>().Play();
                StartCoroutine(Wait());
            }
            else
            {
            particle.GetComponent<ParticleSystem>().Stop();
            }
    }

    

    IEnumerator Wait()
    {
        
        yield return new WaitForSeconds(10);
        leverfil.SetActive(true);
            
        particle.GetComponent<ParticleSystem>().Stop();
        StopCoroutine(Wait());

    }
}
