using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyStay : MonoBehaviour {

    public GameObject lockSlot;
    Rigidbody rb;
    Key keyScript;

    // Use this for initialization
    void Start ()
    {
        keyScript = lockSlot.GetComponent<Key>();
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(keyScript.unlocked)
        {
            transform.position = lockSlot.transform.position;
            transform.rotation = lockSlot.transform.rotation;
            rb.isKinematic = true;
            gameObject.layer = 0;
        }
	}
}
