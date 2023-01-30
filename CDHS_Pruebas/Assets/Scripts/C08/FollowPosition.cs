using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPosition : MonoBehaviour
{
    [SerializeField] private Transform playerToFollow;
    [SerializeField] private float speedRotation = 15.0f;

    [SerializeField] private float speedMovement = 10.0f;
    [SerializeField] private float maxDistance = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //  Rotar
    void RotateToPlayer()
    {
        Quaternion rotateTo = Quaternion.LookRotation(playerToFollow.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotateTo, speedRotation * Time.deltaTime);
    }
    //  Mover
    void MoveToPlayer()
    {
        Vector3 moveTo = playerToFollow.position - transform.position;
        if (moveTo.magnitude >= maxDistance)
            transform.Translate(moveTo.normalized * speedMovement * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        RotateToPlayer();
        MoveToPlayer();
    }
}
