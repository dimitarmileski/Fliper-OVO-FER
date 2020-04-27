﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FliperScript : MonoBehaviour
{
    public float fliperRestPosition = 0f;
    public float fliperDamperProp = 150f;
    public float hitStrength = 10000f;
    public float pressedPostionAngle = 45f;
    HingeJoint hinge;
    public string inputName;

    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

 
void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrength;
        spring.damper = fliperDamperProp;
        if(Input.GetAxis(inputName) == 1)
        {
            spring.targetPosition = pressedPostionAngle;

        }
        else
        {
            spring.targetPosition = fliperRestPosition;
        }

        hinge.spring = spring;
        hinge.useLimits = true;
          
    }
}
