using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyStay : MonoBehaviour
{
    public GameObject lockSlot;
    Rigidbody rb;
    Key keyScript;

    void Start ()
    {
        keyScript = lockSlot.GetComponent<Key>();
        rb = GetComponent<Rigidbody>();
    }

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
