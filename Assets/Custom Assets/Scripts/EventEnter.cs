using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventEnter : MonoBehaviour
{
    public GameObject eventObject;

    void OnTriggerEnter (Collider other) {
        if(eventObject != null)
        {
            eventObject.SetActive(true);
        }

    }

    void OnTriggerExit (Collider other) {
        // Do nothing
    }
}
