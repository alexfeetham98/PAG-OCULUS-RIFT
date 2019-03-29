using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVRTouchSample;

public class ButtonPress : MonoBehaviour
{
    public GameObject platform;
    public GameObject hand;
    PlatformMovement PMS;
    Renderer rend;

    public bool unlocked = false;

	void Start ()
    {
        PMS = platform.GetComponent<PlatformMovement>();
        //rend = GetComponent<Renderer>();
        //rend.enabled = false;
        
	}

    private void OnTriggerEnter(Collider other)
    {
        if (unlocked)
        {
            rend.enabled = true;
            if (other.gameObject == hand)
            {
                PMS.riding = true;
                Debug.Log(PMS.riding);
                Destroy(gameObject);
            }
        }        
    }
}