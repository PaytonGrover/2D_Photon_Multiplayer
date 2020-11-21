using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpener : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private bool openTrigger = false;

    [SerializeField] private string doorOpen = "doorOpen";

    private void OnTrigggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                myDoor.Play("doorOpen", 0, 0.0f);
                gameObject.SetActive(false);
            }
            else if (openTrigger)
            {
                //myDoor.Play("doorOpen", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }
}
