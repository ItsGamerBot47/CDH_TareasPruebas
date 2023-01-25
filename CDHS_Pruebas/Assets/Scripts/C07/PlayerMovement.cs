using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private bool actionMode = true;
    [SerializeField] private float speedChara = 20.0f;

    void moveChara(Vector3 direction)
    {
        transform.position += (direction * Time.deltaTime * speedChara);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (actionMode)
        {
            if (Input.GetKey(KeyCode.W))        moveChara(Vector3.forward);
            if (Input.GetKey(KeyCode.S))        moveChara(Vector3.back);
            if (Input.GetKey(KeyCode.D))        moveChara(Vector3.right);
            if (Input.GetKey(KeyCode.A))        moveChara(Vector3.left);
        }
    }
}
