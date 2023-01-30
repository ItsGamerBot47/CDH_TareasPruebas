using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform playerToFollow;
    [SerializeField] private float speedRotation = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rotateTo = Quaternion.LookRotation(playerToFollow.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotateTo, speedRotation * Time.deltaTime);
    }
}
