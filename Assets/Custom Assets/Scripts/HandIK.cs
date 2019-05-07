using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandIK : MonoBehaviour
{

    Animator anim;

    public float ikWeight = 1f;

    public Transform leftHandTarget;
    public Transform rightHandTarget;

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
        anim.SetIKPositionWeight(AvatarIKGoal.LeftHand, ikWeight);
        anim.SetIKPositionWeight(AvatarIKGoal.RightHand, ikWeight);

        anim.SetIKPosition(AvatarIKGoal.LeftHand, leftHandTarget.position);
        anim.SetIKPosition(AvatarIKGoal.RightHand, rightHandTarget.position);
    }
}
