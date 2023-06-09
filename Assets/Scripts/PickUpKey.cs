using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{
    public GameObject keyOB;
    public GameObject invOB;
    public AudioSource keySound;

    public bool inReach;


    void Start()
    {
        inReach = false;
        
        invOB.SetActive(false);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            

        }
    }


    void Update()
    {
        if (inReach && Input.GetKeyDown(KeyCode.E))
        {
            keyOB.SetActive(false);
            keySound.Play();
            invOB.SetActive(true);
           
        }


    }
}