using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkEndScenario : MonoBehaviour
{
    public float playerActionNumber;

    public Transform filterTransform;
    public  float distanceToFilter;
    public Transform filterPlaceTransform;
    private bool filterHoldPlace = false;

    public Transform holderTransform;
    public float distanceToHolderPlace;
    public Transform holderPlaceTransform;
    private bool holderHoldPlace = false;

    public Transform chemsTransform;
    
    void Start()
    {
        playerActionNumber = 1f;
        filterTransform = GameObject.FindWithTag("BlindFilter").transform;

    }

    void Update()
    {
        if (filterHoldPlace)
        {
            filterTransform.position = filterPlaceTransform.position;
        }

        if (holderHoldPlace)
        {
            holderTransform.position = holderPlaceTransform.position;
        }
        
        

        switch (playerActionNumber)
        {
            //1. setting the blind filter
            case 1:
                Debug.Log("case 1");
                distanceToFilter = Vector3.Distance(filterTransform.position, holderTransform.position);
                if (distanceToFilter <= 0.1f)
                {
                    addBlindFilter();
                }
                break;
            
            //2.1 adding some chemicals
            case 2:
                // if ()
                // {
                //     
                // }
                
                addChemicals();
                break;
            
            //2.2 set up holder
            case 3:
                Debug.Log("case 3");
                distanceToHolderPlace = Vector3.Distance(holderPlaceTransform.position, holderTransform.position);
                if (distanceToHolderPlace <= 0.4f)
                {
                    setUpHolder();
                }
                break;
            
            //3.1 Set ON the "group" 5 times
            case 4:
                pressButtonFiveTimes();
                break;
            
            //////////////////

        }
    }

    void addBlindFilter()
    {
        filterTransform.parent = holderTransform;
        filterTransform.position = filterPlaceTransform.position;
        filterHoldPlace = true;
        
        playerActionNumber += 1;
        Debug.Log("addBlindFilter DONE ");
    }

    void addChemicals()
    {
        //TODO make addChemicals()
        
        playerActionNumber += 1;
        // Debug.Log("addChemicals DONE ");
    }

    void setUpHolder() //into work group
    {
        filterTransform.position = holderPlaceTransform.position;
        filterTransform.rotation = holderPlaceTransform.rotation;
        
        holderHoldPlace = true;
        playerActionNumber += 1;
        Debug.Log("setUpHolder DONE ");
    }

    void pressButtonFiveTimes()
    {
        
        
        playerActionNumber += 1;
        Debug.Log("pressButtonFiveTimes DONE ");
    }

    void pressButton()
    {
        
    }

    

}