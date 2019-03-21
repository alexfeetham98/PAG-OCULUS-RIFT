using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public GameObject lockSlot;
    Key keyScript;

	// Use this for initialization
	void Start ()
    {
        keyScript = lockSlot.GetComponent<Key>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(keyScript.unlocked)
        {
            Destroy(this.gameObject);
        }
	}
}
