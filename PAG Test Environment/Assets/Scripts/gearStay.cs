using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearStay : MonoBehaviour {

    public GameObject gearSlot;
    public GameObject button;
    ButtonPress BPS;
    Rigidbody rb;
    Gear gearScript;
    float timer = 0f;
    OVRGrabbable script;

    public bool rotate = false;

    // Use this for initialization
    void Start ()
    {
        gearScript = gearSlot.GetComponent<Gear>();
        rb = GetComponent<Rigidbody>();
        script = this.GetComponent<OVRGrabbable>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(gearScript.unlocked)
        {
            gameObject.layer = 0;
            if (rotate)
            {
                transform.position = gearSlot.transform.position;
                transform.Rotate(0, 0, 20 * Time.deltaTime);
                script.enabled = false;
            }
            else
            {
                transform.position = gearSlot.transform.position;
                transform.rotation = gearSlot.transform.rotation;
            }
            rb.isKinematic = true;
            timer += Time.deltaTime;
        }
	}
}
