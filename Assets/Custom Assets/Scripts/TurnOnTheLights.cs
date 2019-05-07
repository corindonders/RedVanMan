using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnTheLights : MonoBehaviour
{
    public Light carLight;
    public Light lfLight;
    public Light rfLight;
    public Light lbLight;
    public Light rbLight;

    public Renderer lightRenderer;


    void OnTriggerEnter (Collider other){
        Material mat = lightRenderer.material; 
        
        carLight.enabled = !carLight.enabled;
        lfLight.enabled = !lfLight.enabled;
        rfLight.enabled = !rfLight.enabled;
        lbLight.enabled = !lbLight.enabled;
        rbLight.enabled = !rbLight.enabled;
        mat.EnableKeyword("_EMISSION");
    }
}
