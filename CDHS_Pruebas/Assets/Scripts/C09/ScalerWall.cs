using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalerWall : MonoBehaviour
{
    [SerializeField] public PlayerMoving3rdPerson playerScript;

    void ScalePlayer(bool parameter)
    {
        playerScript.shrinker.SetBool("WallTouched", parameter);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerScript.scaleTransformed = !playerScript.scaleTransformed;
            ScalePlayer(playerScript.scaleTransformed);
        }
    }
}
