using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLoop : MonoBehaviour
{
    [SerializeField] private float speedMovement = 9.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale *= 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += ((0.1f * Vector3.down) * speedMovement * Time.deltaTime);
        if (Mathf.Round(transform.position.y) <= 2.5)
            transform.position += new Vector3(0, 1.5f, 0);
    }
}
