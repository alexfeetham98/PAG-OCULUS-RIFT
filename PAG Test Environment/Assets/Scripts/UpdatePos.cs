using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatePos : MonoBehaviour
{
    public GameObject cam;
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = cam.transform.position;
        transform.rotation = cam.transform.rotation;
	}
}
