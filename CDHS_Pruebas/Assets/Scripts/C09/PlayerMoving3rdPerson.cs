using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving3rdPerson : MonoBehaviour
{
    [SerializeField] public Animator shrinker;
    [SerializeField] private float speedPlayer = 1.4f;
    [SerializeField] public bool scaleTransformed = false;
    [SerializeField] private float rotateSpeed = 2.0f;
    private float horCam = 0.0f;
    private float verCam = 0.0f;

    void RotateVision()
    {
        //  Mouse
        horCam = rotateSpeed * Input.GetAxis("Mouse X");
        transform.Rotate(verCam, horCam, 0.0f);
        Cursor.lockState = CursorLockMode.Locked;
    }

    void MovePlayer(Vector3 direction)
    {
        transform.Translate(direction * (speedPlayer * Time.deltaTime));
    }
    void KeyboardMovement()
    {
        //  WASD
        if (Input.GetKey(KeyCode.W))    MovePlayer(Vector3.forward);
        if (Input.GetKey(KeyCode.A))    MovePlayer(Vector3.left);
        if (Input.GetKey(KeyCode.S))    MovePlayer(Vector3.back);
        if (Input.GetKey(KeyCode.D))    MovePlayer(Vector3.right);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        KeyboardMovement();
        RotateVision();
    }
    private void OnTriggerEnter(Collider other)
    {
        ScalerWall pared = other.GetComponent<ScalerWall>();
        bool shrinkerYN = (pared != null);
        
        Debug.Log("NOMBRE: " + other.gameObject.name + " | SHRINKER: " + shrinkerYN.ToString());
    }
    private void OnCollisionEnter(Collision other)
    {
        ScalerWall pared = other.collider.GetComponent<ScalerWall>();
        bool shrinkerYN = (pared != null);
        
        Debug.Log("NOMBRE: " + other.gameObject.name + " | SHRINKER: " + shrinkerYN.ToString());
    }
}
