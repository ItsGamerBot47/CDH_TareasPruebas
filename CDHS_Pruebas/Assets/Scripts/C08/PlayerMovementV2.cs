using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementV2 : MonoBehaviour
{
    [SerializeField] private bool activateScript = true;
    [SerializeField] private float speedPlayer = 1.2f;

    void MovePlayer(Vector3 direction)
    {
        transform.Translate(direction * (speedPlayer * Time.deltaTime));
    }
    void KeyboardMovement()
    {
        if (Input.GetKey(KeyCode.W))    MovePlayer(Vector3.forward + Vector3.right);
        if (Input.GetKey(KeyCode.A))    MovePlayer(Vector3.forward + Vector3.left);
        if (Input.GetKey(KeyCode.S))    MovePlayer(Vector3.back + Vector3.left);
        if (Input.GetKey(KeyCode.D))    MovePlayer(Vector3.back + Vector3.right);
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
            KeyboardMovement();
        }
    }
}
