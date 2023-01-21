using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCanon : MonoBehaviour
{
    [SerializeField] private bool activateScript;
    public GameObject bulletObject;
    public Transform spawnBulletFromCanon;
    [SerializeField] private float cooldown = 2.5f;
    [SerializeField] private int bulletsShot;
    [SerializeField] private bool canShoot = true;
    [SerializeField] private float auxShootTime = 0.0f;
    [SerializeField] private float auxOtherShootTime = 0.0f;

    void CreateBullet(int bullets)
    {
        canShoot = false;
        switch (bullets)
        {
            case 1:
            {
                bulletsShot = 1;
                Instantiate(bulletObject, spawnBulletFromCanon.position, spawnBulletFromCanon.rotation);
                break;
            }
            case 2:
            {
                bulletsShot = 2;
                Instantiate(bulletObject, spawnBulletFromCanon.position, spawnBulletFromCanon.rotation);
                break;
            }
            case 3:
            {
                bulletsShot = 3;
                Instantiate(bulletObject, spawnBulletFromCanon.position, spawnBulletFromCanon.rotation);
                break;
            }
            case 4:
            {
                bulletsShot = 4;
                Instantiate(bulletObject, spawnBulletFromCanon.position, spawnBulletFromCanon.rotation);
                break;
            }
        }
    }

    void OtherBullets(int bullets)
    {
        //  Caso de más balas
        switch (bulletsShot)
        {
            case 2:
            {
                if (auxOtherShootTime >= 1.5f)
                {
                    Instantiate(bulletObject, spawnBulletFromCanon.position, spawnBulletFromCanon.rotation);
                    auxOtherShootTime = 0.0f;
                }
                break;
            }
            case 3:
            {
                if (auxOtherShootTime >= 1.0f)
                {
                    Instantiate(bulletObject, spawnBulletFromCanon.position, spawnBulletFromCanon.rotation);
                    auxOtherShootTime = 0.0f;
                }
                break;
            }
            case 4:
            {
                if (auxOtherShootTime >= 0.8f)
                {
                    Instantiate(bulletObject, spawnBulletFromCanon.position, spawnBulletFromCanon.rotation);
                    auxOtherShootTime = 0.0f;
                }
                break;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (activateScript)
        {
            bulletsShot = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (activateScript)
        {
            //  Cantidad de disparos
            if (canShoot)
            {
                if (Input.GetKeyDown(KeyCode.Space))    CreateBullet(1);
                if (Input.GetKeyDown(KeyCode.J))        CreateBullet(2);
                if (Input.GetKeyDown(KeyCode.K))        CreateBullet(3);
                if (Input.GetKeyDown(KeyCode.L))        CreateBullet(4);
            }
            else
            {
                auxShootTime += Time.deltaTime;
                auxOtherShootTime += Time.deltaTime;
            }

            OtherBullets(bulletsShot);

            if (auxShootTime >= cooldown)
            {
                canShoot = true;
                bulletsShot = 0;
                auxShootTime = 0.0f;
                auxOtherShootTime = 0.0f;
            }
        }
    }
}
