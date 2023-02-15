using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingOneRaycast : MonoBehaviour
{
    [SerializeField] private Transform ejeView;
    [SerializeField] private float raycastDistance = 2f;
    [SerializeField] private LayerMask layersToCollideWith;
    [SerializeField] private Animator doorToOpen;
    private bool openingDoor = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))    CreateRaycast();
    }

    private void CreateRaycast()
    {
        var hasCollided = Physics.Raycast(ejeView.position, ejeView.forward, out RaycastHit raycastHitInfo, raycastDistance, layersToCollideWith);
        if (hasCollided)
        {
            //  Abrir Puerta
            if (raycastHitInfo.collider.CompareTag("Door"))
            {
                openingDoor = !openingDoor;
                doorToOpen.SetBool("Door Opening", openingDoor);
            }
        }
    }
}
