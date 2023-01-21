using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticShot : MonoBehaviour
{
    public BulletScalated scriptBullet;
    public GameObject bulletObject;
    public Transform spawnBulletFromCanon;
    [SerializeField] private bool activateScript;
    [SerializeField] private bool canShoot;
    [SerializeField] private float totalTime;

    void ShootBullet()
    {
        canShoot = false;
        Instantiate(bulletObject, spawnBulletFromCanon.position, spawnBulletFromCanon.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        totalTime = 0.0f;
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (activateScript)
        {
            if (canShoot)   ShootBullet();
            else            totalTime += Time.deltaTime;

            if (totalTime >= scriptBullet.timeMovement)
            {
                canShoot = true;
                totalTime = 0;
            }
        }
    }
}
