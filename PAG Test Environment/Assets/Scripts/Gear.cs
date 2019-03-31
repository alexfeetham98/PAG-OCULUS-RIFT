using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour
{
    public GameObject gear;
    Rigidbody gearRb;
    public bool unlocked;
    Renderer rend;
    public GameObject button;
    ButtonPress buttonScript;

    void Start()
    {
        gearRb = gear.GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        buttonScript = button.GetComponent<ButtonPress>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == gear)
        {
            unlocked = true;
            gearRb.isKinematic = true;
            rend.enabled = false;
            buttonScript.active = true;
        }
    }
}