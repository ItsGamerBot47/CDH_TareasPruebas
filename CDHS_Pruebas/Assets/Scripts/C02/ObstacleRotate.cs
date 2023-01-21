using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRotate : MonoBehaviour
{
    [SerializeField] private float speedRotation = 8.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * speedRotation);
    }
}
