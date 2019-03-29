using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSlot : MonoBehaviour
{
    public GameObject platform;
    public GameObject key;
    PlatformMovement PMS;
    Rigidbody keyRb;

	void Start ()
    {
        PMS = platform.GetComponent<PlatformMovement>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == key)
        {
            PMS.riding = true;
        }
    }
}
