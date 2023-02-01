using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenWall : MonoBehaviour
{
    [SerializeField] private GameObject goldenWall;
    [SerializeField] private Transform[] wallPoints;
    [SerializeField] public float collidingTime = 2.0f;
    [SerializeField] public float timeWhileColliding;
    [SerializeField] public int numberWall;
    public GameObject auxWall;

    // Start is called before the first frame update
    void Start()
    {
        timeWhileColliding = 0.0f;
        numberWall = 0;
        ChangePoint(0);
    }

    // Update is called once per frame
    void Update()
    {
        ChangePoint(numberWall);
    }

    public void ChangePoint(int theNumberWall)
    {
        goldenWall.transform.position = wallPoints[theNumberWall].position;
        goldenWall.transform.rotation = wallPoints[theNumberWall].rotation;
    }
}
