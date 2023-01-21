using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaAttributes : MonoBehaviour
{
    [SerializeField] private bool actionMode = true;
    [SerializeField] private int lifeChara = 5;
    [SerializeField] private float speedChara = 20.0f;
    [SerializeField] private Vector3 directionChara;

    //  MÉTODOS
    void healChara(int addLife)
    {
        lifeChara += addLife;
        Debug.Log("1 vida añadida.");
    }
    void damageChara(int takeLife)
    {
        if (lifeChara - takeLife <= 0)
        {
            lifeChara = 0;
            Debug.Assert(lifeChara > 0, "Sin vidas.");
            Debug.Break();
        }
        else
        {
            lifeChara -= takeLife;
            Debug.Log("1 vida Quitada.");
        }
    }
    void moveChara(Vector3 direction)
    {
        transform.position += (direction * Time.deltaTime * speedChara);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (actionMode)
        {
            //  Curar
            if (Input.GetKeyDown(KeyCode.F1))   healChara(1);
            //  Dañar
            if (Input.GetKeyDown(KeyCode.F2))   damageChara(1);
            //  Mover
            if (Input.GetKey(KeyCode.W))        moveChara(Vector3.forward);
            if (Input.GetKey(KeyCode.S))        moveChara(Vector3.back);
            if (Input.GetKey(KeyCode.D))        moveChara(Vector3.right);
            if (Input.GetKey(KeyCode.A))        moveChara(Vector3.left);
            if (Input.GetKey(KeyCode.E))        moveChara(Vector3.up);
            if (Input.GetKey(KeyCode.Q))        moveChara(Vector3.down);
        }
    }
}
