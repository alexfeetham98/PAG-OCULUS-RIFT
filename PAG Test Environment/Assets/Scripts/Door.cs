using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public GameObject[] Slots;
    public GameObject[] Keys;

    bool red = false;
    bool pink = false;
	
	// Update is called once per frame
	void Update ()
    {
        if (Keys[0].transform.position == Slots[0].transform.position)
        {
            red = true;
            Slots[0].layer = 0;
            Keys[0].layer = 0;
        }
        if (Keys[1].transform.position == Slots[1].transform.position)
        {
            pink = true;
            Slots[1].layer = 0;
            Keys[1].layer = 0;
        }
        if (red && pink)
        {
            Destroy(this.gameObject);
        }
	}
}
