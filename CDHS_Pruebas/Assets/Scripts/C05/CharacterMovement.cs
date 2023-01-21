using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private bool activateScript;
    [SerializeField] private bool actionMode = true;
    [SerializeField] private float speedChara = 15.0f;

    void MoveCharacter(Vector3 direction)
    {
        transform.position += (direction * Time.deltaTime * speedChara);
    }
    void Movement()
    {
        if (Input.GetKey(KeyCode.A))    MoveCharacter(Vector3.back);
        if (Input.GetKey(KeyCode.D))    MoveCharacter(Vector3.forward);
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
            if (actionMode)         Movement();
        }
    }
}
