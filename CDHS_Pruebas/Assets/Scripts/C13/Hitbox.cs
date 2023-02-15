using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour
{
    [SerializeField] private Transform[] eyeViews;
    [SerializeField] private float raycastDistance = 2.0f;
    [SerializeField] private LayerMask layerToCollideWith;
    
    private void Update()
    {
        CreateRaycast();
    }
    private void CreateRaycast()
    {
        var hasCollidedForward = Physics.Raycast(eyeViews[0].position, eyeViews[0].forward, out RaycastHit raycastHitInfoF, raycastDistance, layerToCollideWith);
        var hasCollidedOther = Physics.Raycast(eyeViews[1].position, eyeViews[1].forward, out RaycastHit raycastHitInfoB, raycastDistance, layerToCollideWith);
        if (hasCollidedForward || hasCollidedOther)
        {
            Debug.Log("Saltar mensaje simulando la presentación de un 'escudo' como los límites del mapa");
        }
    }
}
