using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCameraAroundPlayer : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 2.0f;
    private float horCam = 0.0f;
    private float verCam = 0.0f;

    void RotateVision()
    {
        //  Mouse
        //horCam = rotateSpeed * Input.GetAxis("Mouse X");
        verCam = rotateSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(-verCam, horCam, 0.0f);
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateVision();
    }
}
