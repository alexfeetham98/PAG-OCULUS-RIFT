using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public GameObject SpawnPointHard;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = SpawnPointHard.transform.position;
            other.transform.rotation = SpawnPointHard.transform.rotation;
        }
    }
}