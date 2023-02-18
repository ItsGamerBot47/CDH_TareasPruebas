using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToSpawn : MonoBehaviour
{
    [SerializeField] private Transform ReturnToCheckpoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = ReturnToCheckpoint.position;
        }
    }
}
