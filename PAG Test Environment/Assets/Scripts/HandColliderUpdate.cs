using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandColliderUpdate : MonoBehaviour
{
    public GameObject hand;

	void Start ()
    {
        transform.position = hand.transform.position;
        transform.rotation = hand.transform.rotation;
	}

	void Update ()
    {
        transform.position = hand.transform.position;
        transform.rotation = hand.transform.rotation;
    }
}
