using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    [SerializeField] private float speedMovement = 18.0f;
    [SerializeField] private float limitXZ = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Mathf.Round(transform.position.x) <= limitXZ && Mathf.Round(transform.position.x) >= -limitXZ)
        {
            //  Mover hacia X
            if (Mathf.Round(transform.position.z) == limitXZ)
                transform.position += ((0.1f * Vector3.left) * speedMovement * Time.deltaTime);
            //  Volver a X
            if (Mathf.Round(transform.position.z) == -limitXZ)
                transform.position += ((0.1f * Vector3.right) * speedMovement * Time.deltaTime);
        }
        if (Mathf.Round(transform.position.z) <= limitXZ && Mathf.Round(transform.position.z) >= -limitXZ)
        {
            //  Mover hacia Z
            if (Mathf.Round(transform.position.x) == -limitXZ)
                transform.position += ((0.1f * Vector3.back) * speedMovement * Time.deltaTime);
            //  Volver a Z
            if (Mathf.Round(transform.position.x) == limitXZ)
                transform.position += ((0.1f * Vector3.forward) * speedMovement * Time.deltaTime);
        }        
    }
}
