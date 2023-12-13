/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepSound : MonoBehaviour
{
    public AudioSource footstepsSound; //sprintSound

    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)){
            /*
            if (Input.GetKey(KeyCode.LeftShift))
            {
                footstepsSound.enabled = false;
                sprintSound.enabled = true;
            }
            else
            
            {
                footstepsSound.enabled = true;
                //sprintSound.enabled = false;
            }
        }
        else
        {
            footstepsSound.enabled = false;
            //sprintSound.enabled = false;
        }
    }
}
*/
/*
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StepSound : MonoBehaviour
{
    public AudioSource audioSource, sprintSound;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)){
            
            if (Input.GetKey(KeyCode.LeftShift))
            {
                audioSource.enabled = false;
                sprintSound.enabled = true;
            }
            else
            {
                audioSource.enabled = true;
                sprintSound.enabled = false;
            }
        }
        else
        {
            audioSource.enabled = false;
            sprintSound.enabled = false;
        }
    }
}
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    public AudioSource footstepsSound, sprintSound;

    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)){
            if (Input.GetKey(KeyCode.LeftShift))
            {
                footstepsSound.enabled = false;
                sprintSound.enabled = true;
            }
            else
            {
                footstepsSound.enabled = true;
                sprintSound.enabled = false;
            }
        }
        else
        {
            footstepsSound.enabled = false;
            sprintSound.enabled = false;
        }
    }
}

