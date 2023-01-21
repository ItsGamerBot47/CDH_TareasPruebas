using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] private Vector3 directionMovement;
    [SerializeField] private float timeMovement = 3.0f;
    [SerializeField] private float speedMovement = 1.6f;
    private float totalTimeMovement;

    // Start is called before the first frame update
    void Start()
    {
        totalTimeMovement = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        totalTimeMovement += Time.deltaTime;
        transform.position += directionMovement * speedMovement * Time.deltaTime;
        if (totalTimeMovement >= timeMovement)
            Object.Destroy(gameObject, timeMovement);
    }
}
