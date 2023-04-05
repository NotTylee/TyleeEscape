using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    public AudioSource chest;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Reach"))
        {
            if (openTrigger)
            {
                chest.Play();
                myDoor.Play("Open", 0, 0.0f);
                gameObject.SetActive(false);
            }

            else if (closeTrigger)
            {
                myDoor.Play("Close", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }
}
