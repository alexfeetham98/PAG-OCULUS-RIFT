using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject[] Slots;
    public GameObject[] Keys;

    bool one = false;
    bool two = false;
	
	void Update ()
    {
        if (Slots.Length == 1 && Keys.Length == 1)
        {
            if (Keys[0].transform.position == Slots[0].transform.position)
            {
                one = true;
                Slots[0].layer = 0;
                Keys[0].layer = 0;
            }
            if (one)
            {
                Destroy(gameObject);
            }
        }
             


        if (Slots.Length == 2 && Keys.Length == 2)
        {
            if (Keys[0].transform.position == Slots[0].transform.position)
            {
                one = true;
                Slots[0].layer = 0;
                Keys[0].layer = 0;
            }
            if (Keys[1].transform.position == Slots[1].transform.position)
            {
                two = true;
                Slots[1].layer = 0;
                Keys[1].layer = 0;
            }
            if (one && two)
            {
                Destroy(this.gameObject);
            }
        }
	}
}
