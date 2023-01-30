using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomEnemy : MonoBehaviour
{
    [SerializeField] private enemyType enemyMode;
    [SerializeField] private Transform playerToFollow;
    [SerializeField] private float speedRotation = 15.0f;

    [SerializeField] private float speedMovement = 10.0f;
    [SerializeField] private float maxDistance = 2.0f;

    public enum enemyType
    {
        enemy1, enemy2
    }

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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (enemyMode)
        {
            case enemyType.enemy1:
            {
                RotateToPlayer();
                break;
            }
            case enemyType.enemy2:
            {
                MoveToPlayer();
                RotateToPlayer();
                break;
            }
        }
    }
}
