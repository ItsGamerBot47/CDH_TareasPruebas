using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private int totalLife = 5;
    private TestingPlayer testingThePlayer;
    
    private void Awake()
    {
        if (instance != null)   //  En existencia
        {
            Destroy(gameObject);
        }
        else                    //  Sin existir aún
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
    }

    //  GET - SET
    //  Jugador
    public TestingPlayer GetTestingPlayer()
    {
        return testingThePlayer;
    }
    public void SetTestingPlayer(TestingPlayer somePlayer)
    {
        testingThePlayer = somePlayer;
    }

    public void AddLife(int lifeToAdd)
    {
        totalLife += lifeToAdd;
    }
    public void ReduceLife(int lifeToReduce)
    {
        totalLife -= lifeToReduce;
    }
}
