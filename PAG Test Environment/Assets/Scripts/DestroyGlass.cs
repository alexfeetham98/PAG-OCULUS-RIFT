using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGlass
    : MonoBehaviour
{
    public GameObject glass;
    public Rigidbody key;
	
	void Update ()
    {
        if (key.transform.position == transform.position)
        {
            Destroy(glass);
        }
	}
}
