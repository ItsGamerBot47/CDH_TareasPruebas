using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private bool activeScript;
    [SerializeField] private CinemachineVirtualCamera[] cameraList;
    [SerializeField] private bool cameraFocus;

    // Start is called before the first frame update
    void Start()
    {
        if (activeScript)
        {
            cameraFocus = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (activeScript)
        {
            if (Input.GetKeyDown(KeyCode.E))    cameraFocus = !cameraFocus;

            cameraList[0].gameObject.SetActive(cameraFocus);
            cameraList[1].gameObject.SetActive(!cameraFocus);
        }
    }
}
