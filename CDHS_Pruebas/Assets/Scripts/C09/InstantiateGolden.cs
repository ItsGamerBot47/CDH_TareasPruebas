using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateGolden : MonoBehaviour
{
    [SerializeField] public GoldenWall wallScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision other)
    {
        wallScript.timeWhileColliding += Time.deltaTime;
        if (wallScript.timeWhileColliding >= wallScript.collidingTime)
        {
            if (wallScript.numberWall + 1 >= 4)     wallScript.numberWall = 0;
            else                                    wallScript.numberWall++;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        wallScript.timeWhileColliding = 0.0f;
    }
}
