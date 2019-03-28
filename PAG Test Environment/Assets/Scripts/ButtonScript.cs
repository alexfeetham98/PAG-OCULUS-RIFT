using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    PlatformMovement PMScript;

	void Start ()
    {
        PMScript = GetComponent<PlatformMovement>();
	}

    void OnTriggerEnter(Collision other)
    {
        if(other.gameObject.name == "Button Red")
        {
            PMScript.riding = true;
        }
    }

    void Update ()
    {
		
	}
}