using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject objToSpawn;
    //public float timeLeft, originalTime;

    private float spawnPeriod = 2f;
    private float nextSpawnTime;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* timeLeft -= Time.deltaTime;

        if(timeLeft <= 0)
        {
            // used for spawning zombies programmatically every certain amount of time
            //SpawnZombie();
            timeLeft = originalTime;
        }

        if(Input.GetKeyDown(KeyCode.Z))
        {
            SpawnZombie();
        }
        */

        // spawns zombies by pressing 'z' key with a 5 seconds delay
        if (Input.GetKey("z") && Time.time > nextSpawnTime) { 
 
          nextSpawnTime = Time.time + spawnPeriod;
          SpawnZombie();
        }

        //CODE FOR DEBUGGING WHEN INSTANTIATING A ZOMBIE
        /* if (Input.GetKeyDown("1"))
        {
            Instantiate(objToSpawn, new Vector3(5.55f, 0.815f, -0.36f), transform.rotation * Quaternion.Euler (0f, -90f, 0f)).GetComponent<MovimientoZombie>().velocidad = 0.25f;
        }

        if (Input.GetKeyDown("2"))
        {
            Instantiate(objToSpawn, new Vector3(5.55f, 0.815f, -1.36f), transform.rotation * Quaternion.Euler (0f, -90f, 0f)).GetComponent<MovimientoZombie>().velocidad = 0.25f;
        }

        if (Input.GetKeyDown("3"))
        {
            Instantiate(objToSpawn, new Vector3(5.55f, 0.815f, -2.36f), transform.rotation * Quaternion.Euler (0f, -90f, 0f)).GetComponent<MovimientoZombie>().velocidad = 0.25f;
        }

        if (Input.GetKeyDown("4")){
            Instantiate(objToSpawn, new Vector3(5.55f, 0.815f, -3.36f), transform.rotation * Quaternion.Euler (0f, -90f, 0f)).GetComponent<MovimientoZombie>().velocidad = 0.25f;
        }

        if (Input.GetKeyDown("5"))
        {
            Instantiate(objToSpawn, new Vector3(5.55f, 0.815f, -4.36f), transform.rotation * Quaternion.Euler (0f, -90f, 0f)).GetComponent<MovimientoZombie>().velocidad = 0.25f;
        } */

    }


    //get a random number from 0 to 4
    int GetRandomTile()
    {
        return Random.Range(0, 5);
    }

    void SpawnZombie()
    {
        // uses random number to spawn zombie in a random tile
        float casilla = (GetRandomTile()* - 1f) - 0.36f;
        Debug.Log(casilla);
        // Instantiate the zombie and assigns it speed
        Instantiate(objToSpawn, new Vector3(5.55f, 0.815f, casilla), transform.rotation * Quaternion.Euler (0f, -90f, 0f)).GetComponent<MovimientoZombie>().velocidad = 0.25f;
    }
    
}
