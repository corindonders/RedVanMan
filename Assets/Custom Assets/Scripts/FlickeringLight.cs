using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    Light lanternLight;
    public float minWaitTime;
    public float maxWaitTime;

    public Renderer lightRenderer;


    void Start()
    {
        lanternLight = GetComponent<Light>();
        StartCoroutine(Flashing());
    }

    void Update()
    {
        Material mat = lightRenderer.material;

        if (lanternLight.enabled == true) 
        {
            mat.EnableKeyword("_EMISSION");
        }
        else
        {
            mat.DisableKeyword("_EMISSION");
        }
    }

    IEnumerator Flashing()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
            lanternLight.enabled = !lanternLight.enabled;

        }
    }
}
