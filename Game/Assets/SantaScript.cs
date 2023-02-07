using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantaScript : MonoBehaviour
{
    Animator SantaAnimator;
    float currentspeed, walkingspeed = 3, runningspeed = 6;
    // Start is called before the first frame update
    void Start()
    {
        SantaAnimator = GetComponent<Animator>();
         currentspeed = runningspeed;
    }

    // Update is called once per frame
    void Update()
    {
        SantaAnimator.SetBool("IsRunning", false);
        if (Input.GetKey(KeyCode.W)) MoveForward();
    }

    private void MoveForward()
    {
        transform.position += currentspeed * transform.forward * Time.deltaTime;
        SantaAnimator.SetBool("IsRunning", true);
    }
}
