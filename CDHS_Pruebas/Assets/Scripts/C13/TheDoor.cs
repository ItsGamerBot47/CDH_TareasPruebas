using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheDoor : MonoBehaviour
{
    [SerializeField] private Transform[] eyeViews;
    [SerializeField] private float raycastDistance = 10.0f;
    [SerializeField] private LayerMask layerToCollideWith;
    [SerializeField] private Animator doorAnimation;
    
    private void Awake()
    {
        doorAnimation.SetBool("DoorOpening", false);
    }
    private void Update()
    {
        CreateRaycast();
    }
    private void CreateRaycast()
    {
        var hasCollidedForward = Physics.Raycast(eyeViews[0].position, eyeViews[0].forward, out RaycastHit raycastHitInfoF, raycastDistance, layerToCollideWith);
        var hasCollidedBehind = Physics.Raycast(eyeViews[1].position, eyeViews[1].forward, out RaycastHit raycastHitInfoB, raycastDistance, layerToCollideWith);
        var hasCollidedUnder = Physics.Raycast(eyeViews[2].position, eyeViews[2].up, out RaycastHit raycastHitInfoU, raycastDistance, layerToCollideWith);
        if (hasCollidedForward || hasCollidedBehind || hasCollidedUnder)
        {
            doorAnimation.SetBool("DoorOpening", true);
        }
        else
        {
            doorAnimation.SetBool("DoorOpening", false);
        }
    }
}
