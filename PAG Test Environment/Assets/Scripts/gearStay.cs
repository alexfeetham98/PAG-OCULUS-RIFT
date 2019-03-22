using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gearStay : MonoBehaviour {

    public GameObject lockSlot;
    Rigidbody rb;
    Gear keyScript;
    float timer = 0f;

    // Use this for initialization
    void Start ()
    {
        keyScript = lockSlot.GetComponent<Gear>();
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(keyScript.unlocked)
        {
            if (timer < 0.25f)
            {
                transform.rotation = lockSlot.transform.rotation;
            }
            else
            {
                transform.position = lockSlot.transform.position;
                transform.Rotate(0, 0, 20 * Time.deltaTime);
                
                gameObject.layer = 0;
            }
            rb.isKinematic = true;
            timer += Time.deltaTime;
        }
	}
}
