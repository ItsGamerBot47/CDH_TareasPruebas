using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLifeArea : MonoBehaviour
{
    [SerializeField] private GameObject cubeToAdd;
    [SerializeField] private float respawnTime = 3.0f;
    [SerializeField] private float totalTime;
    [SerializeField] private bool itemTaken;

    private void Awake()
    {
        itemTaken = false;
    }
    private void Update()
    {
        if (itemTaken)
        {
            if (totalTime == 0)
                GameManager.instance.AddLife(1);
            cubeToAdd.SetActive(false);
            totalTime += Time.deltaTime;
        }
        if (totalTime >= respawnTime)
        {
            totalTime = 0;
            itemTaken = false;
            cubeToAdd.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            itemTaken = true;
        }
    }
}
