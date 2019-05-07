using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTriggers : MonoBehaviour
{
    public GameObject LanternNormal;
    public GameObject LanternFlicker;

    void OnTriggerEnter (Collider other){
        LanternNormal.SetActive(false);
        LanternFlicker.SetActive(true);

    }

    void OnTriggerExit (Collider other){
        LanternNormal.SetActive(true);
        LanternFlicker.SetActive(false);

    }
}
