using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnter : MonoBehaviour
{
    public GameObject Screen01;
    public GameObject LanternNormal;
    public GameObject LanternFlicker;

    void OnTriggerEnter (Collider other){
        Debug.Log ("TRIGGER ENTER");
        Screen01.SetActive(true);
        LanternNormal.SetActive(false);
        LanternFlicker.SetActive(true);

    }

    void OnTriggerExit (Collider other){
        Debug.Log ("TRIGGER EXIT");
        Screen01.SetActive(false);
        LanternNormal.SetActive(true);
        LanternFlicker.SetActive(false);

    }
}
