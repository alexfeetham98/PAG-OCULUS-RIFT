using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject key;
    Rigidbody keyRb;
    public bool unlocked;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == key)
        {
            unlocked = true;
            keyRb.isKinematic = true;
        }
    }

    void Start ()
    {
        keyRb = key.GetComponent<Rigidbody>();
	}
}
