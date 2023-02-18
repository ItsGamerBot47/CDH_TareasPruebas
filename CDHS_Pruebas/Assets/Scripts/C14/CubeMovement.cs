using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [SerializeField] private float speedMovement = 5.0f;
    [SerializeField] private float rotationSpeed = 15.0f;
    [SerializeField] private float jumpForce = 2.0f;
    private Rigidbody rbStuff;
    private bool idleRotation;
    private bool canJump, canReallyJump;
    private Vector3 directionToRotate;
    
    private void Awake()
    {
        idleRotation = false;   //  Teclado
        canJump = false;        //  Collider
        canReallyJump = false;  //  Teclado
        rbStuff = GetComponent<Rigidbody>();
        if (rbStuff == null)
            Debug.LogError("Falta componente Rigbody en " + gameObject.name + ".");
    }
    private void Update()
    {
        MovementInput();
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Acceptable Floor"))
        {
            canJump = true;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.collider.CompareTag("Acceptable Floor"))
        {
            canJump = false;
        }
    }

    private void MovePlayer(Vector3 direction)
    {
        transform.position += direction * Time.deltaTime * speedMovement;
        directionToRotate = direction;
        idleRotation = true;
    }
    private void RotatePlayer(Vector3 directionToLook)
    {
        Quaternion newRotation = Quaternion.LookRotation(directionToLook);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, rotationSpeed * Time.deltaTime);
        if (newRotation == transform.rotation)
            idleRotation = false;
    }
    private void JumpPlayer()
    {
        if (canJump && canReallyJump)
            rbStuff.AddForce(jumpForce * Vector3.up, ForceMode.Impulse);
    }
    private void MovementInput()
    {
        //  Mover
        if (Input.GetKey(KeyCode.LeftArrow))    MovePlayer(Vector3.back);
        if (Input.GetKey(KeyCode.RightArrow))   MovePlayer(Vector3.forward);
        //  Rotar
        if (idleRotation)                       RotatePlayer(directionToRotate);
        //  Saltar
        if (Input.GetKey(KeyCode.Z))    canReallyJump = true;
        if (Input.GetKeyUp(KeyCode.Z))  canReallyJump = false;
        JumpPlayer();
    }
}
