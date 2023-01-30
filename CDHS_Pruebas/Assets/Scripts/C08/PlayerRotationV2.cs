using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotationV2 : MonoBehaviour
{
    [SerializeField] private bool activateScript = true;
    [SerializeField] private float rotationSpeed = 15.0f;

    void RotatePlayer(Vector3 direction)
    {
        Quaternion toRotation = Quaternion.LookRotation(direction.normalized);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
    }
    void KeyboardRotation()
    {
        if (Input.GetKey(KeyCode.W))    RotatePlayer(Vector3.forward + Vector3.right);
        if (Input.GetKey(KeyCode.A))    RotatePlayer(Vector3.forward + Vector3.left);
        if (Input.GetKey(KeyCode.S))    RotatePlayer(Vector3.back + Vector3.left);
        if (Input.GetKey(KeyCode.D))    RotatePlayer(Vector3.back + Vector3.right);

        //  Combinaciones
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))     RotatePlayer(Vector3.forward);
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))     RotatePlayer(Vector3.left);
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))     RotatePlayer(Vector3.back);
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))     RotatePlayer(Vector3.right);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activateScript)
        {
            KeyboardRotation();
        }
    }
}
