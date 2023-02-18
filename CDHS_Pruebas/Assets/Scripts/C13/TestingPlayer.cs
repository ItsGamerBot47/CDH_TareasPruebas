using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingPlayer : MonoBehaviour
{
    [SerializeField] private float speedMovement = 1.7f;
    [SerializeField] private float rotationSpeed = 1.8f;
    [SerializeField] private Rigidbody physicsStuff;
    [SerializeField] private float jumpSpeed = 3f;

    private void Awake()
    {
        physicsStuff = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        PlayerMovement();
    }

    void MovePlayer(Vector3 direction)
    {
        transform.position += direction;
    }
    void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MovePlayer(Vector3.back * speedMovement * Time.deltaTime);
            RotatePlayer(Vector3.back);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            MovePlayer(Vector3.forward * speedMovement * Time.deltaTime);
            RotatePlayer(Vector3.forward);
        }
    }
    void JumpPlayer()
    {
        if (Input.GetKey(KeyCode.UpArrow))      physicsStuff.AddForce((jumpSpeed * Vector3.up), ForceMode.Impulse);
    }
    void RotatePlayer(Vector3 directionToLook)
    {
        Quaternion newRotation = Quaternion.LookRotation(directionToLook);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, rotationSpeed * Time.deltaTime);    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Acceptable Floor"))
        {
            JumpPlayer();
        }
    }
    private void OnCollisionStay(Collision other)
    {
        if (other.collider.CompareTag("Acceptable Floor"))
        {
            JumpPlayer();
        }
    }
}
