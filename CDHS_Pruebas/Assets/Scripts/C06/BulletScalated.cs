using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScalated : MonoBehaviour
{
    [SerializeField] public float timeMovement = 3.0f;
    [SerializeField] private Vector3 directionMovement;
    [SerializeField] private float speedMovement = 2.0f;
    [SerializeField] private bool scalated;
    private float auxData = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        scalated = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += directionMovement * speedMovement * Time.deltaTime;
        auxData += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))    scalated = !scalated;

        if (scalated)   transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        else            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        if (auxData >= timeMovement)
            GameObject.Destroy(gameObject);
    }
}
