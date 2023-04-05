using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
   
    public GameObject keyOBNeeded;
   

    public bool inReach;
    



    void Start()
    {
        inReach = false;
        
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
        if (keyOBNeeded.activeInHierarchy == true && inReach && Input.GetKeyDown(KeyCode.E))
        {
            keyOBNeeded.SetActive(false);

            SceneManager.LoadScene("Win");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Debug.Log("You WIn");
        }

        else if (keyOBNeeded.activeInHierarchy == false && inReach && Input.GetKeyDown(KeyCode.E))
        {
           
        }

      
    }
}