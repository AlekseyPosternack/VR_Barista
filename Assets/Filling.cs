using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filling : MonoBehaviour
{
    public List<GameObject> particles;
    public double filling = 0.526;
    private bool collide = false;
    public GameObject cupfil;
    public GameObject leverfil;

    private void Awake()
    {
        particles[0].GetComponent<ParticleSystem>().Stop();
        particles[1].GetComponent<ParticleSystem>().Stop();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cup")
        {
            collide = true;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "cup")
        {
            collide = false;
        }
    }


    public void Fill()
    {



            if (collide & leverfil.activeSelf)
            {
                
                particles[0].GetComponent<ParticleSystem>().Play();
                particles[1].GetComponent<ParticleSystem>().Play();
                StartCoroutine(Wait());
            }
            else
            {
                particles[0].GetComponent<ParticleSystem>().Stop();
                particles[1].GetComponent<ParticleSystem>().Stop();
            }
    }

    

    IEnumerator Wait()
    {
       
         yield return new WaitForSeconds(10);
         cupfil.SetActive(true);
            
        
        particles[0].GetComponent<ParticleSystem>().Stop();
        particles[1].GetComponent<ParticleSystem>().Stop();
        leverfil.SetActive(false);
        StopCoroutine(Wait());

    }
}
