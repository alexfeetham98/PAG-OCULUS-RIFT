using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {
    public GameObject key;
    Rigidbody keyRb;
    public bool unlocked;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == key)
        {
            Debug.Log("collided");
            unlocked = true;
            //key.transform.position = transform.position;
            keyRb.isKinematic = true;
        }
    }

    // Use this for initialization
    void Start ()
    {
        keyRb = key.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
