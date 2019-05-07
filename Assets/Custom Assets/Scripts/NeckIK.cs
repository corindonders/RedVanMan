using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeckIK : MonoBehaviour
{
    Animator anim;

    public float lookIKWeight;
    public float bodyIKWeight;
    public float headWeight;


    public Transform headTarget;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnAnimatorIK()
    {
        anim.SetLookAtWeight(lookIKWeight, bodyIKWeight, headWeight);
        anim.SetLookAtPosition(headTarget.position);
    }
}
