using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLifeItem : MonoBehaviour
{
    [SerializeField] private float itemRotationSpeed = 2.0f;

    private void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * itemRotationSpeed);
    }
}
