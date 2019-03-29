using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyHolder : MonoBehaviour
{
    public GameObject holder;
    public Rigidbody key;
	
	void Update ()
    {
        if (key.transform.position == transform.position)
        {
            Destroy(holder);
        }
	}
}
