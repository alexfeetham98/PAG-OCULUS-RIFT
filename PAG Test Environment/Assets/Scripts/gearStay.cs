﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gearStay : MonoBehaviour {

    public GameObject gearSlot;
    Rigidbody rb;
    Gear keyScript;
    float timer = 0f;
    OVRGrabbable script;

    // Use this for initialization
    void Start ()
    {
        keyScript = gearSlot.GetComponent<Gear>();
        rb = GetComponent<Rigidbody>();
        script = GetComponent<OVRGrabbable>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(keyScript.unlocked)
        {
            if (timer < 0.25f)
            {
                transform.rotation = gearSlot.transform.rotation;
            }
            else
            {
                transform.position = gearSlot.transform.position;
                transform.Rotate(0, 0, 20 * Time.deltaTime);
                script.enabled = false;
                gameObject.layer = 0;
            }
            rb.isKinematic = true;
            timer += Time.deltaTime;
        }
	}
}
