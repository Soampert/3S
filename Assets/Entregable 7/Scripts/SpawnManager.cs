using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{   
    
    /*
   private float RandomY = Random.Range(3f, 13f);
   public Vector3 spawnPos = new Vector3(0, Random.Range(3, 13f), 0);
    */

    public float yRandom;
    
    public float randomY;
    
    public Vector3 spawnPosition;

    public float minY = 3;
    public float maxY = 13;

    /*
    private Vector3 Granizado = new Vector3(0, randomY, 0);
    */

    public float startDelay = 0.5f;
    public float repeatRate = 0.5f;

    public GameObject Bomb;

    private PlayerController playerControllerScript;

    void Start()
    {
        
        /*
        randomY = Random.Range(3f, 13f);
        Vector3 spawnPos = new Vector3(0, randomY, 0);
        */
        
        InvokeRepeating("SpawnBomb", startDelay, repeatRate);
    }


    public Vector3 RandomSpawnPosition()
    {
        /*
        randomY = Random.Range(minY, maxY);
        */

        float yRandom = Random.Range(minY, maxY);
        return new Vector3(15, yRandom, 0);
    }

    void Update()
    {
        
    }

    void SpawnBomb()
    {

        /*
        if(playerControllerScript.gameOver == false)
        {
            Instantiate(Bomb, spawnPos);
        }
        */

        
        spawnPosition = RandomSpawnPosition();
        Instantiate(Bomb, RandomSpawnPosition(), transform.rotation);
        
    }
} 
    