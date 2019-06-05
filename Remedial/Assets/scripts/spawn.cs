using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

    public GameObject[] obstaclePatterns;
    public float timeBSpawn;
    public float startTime;
    public float finalTime;
    public float minTime = 0.65f;

    // Start is called before the first frame update
    void Start()
    {
        timeBSpawn = startTime;
    }

    // Update is called once per frame
    void Update()
    {
       if (timeBSpawn <= 0)                                                                  //mientras el tiempo entre spawn no se menor a 0 entonces
        {
            int rand = Random.Range(0, obstaclePatterns.Length);                             //hace una randon de los patterns
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);    //sin rotación
            timeBSpawn = startTime;                                                          //espera un tiempo para hacer spawn de otro obstaculo
            if (startTime > minTime)                                                         //evalua si el tiempo sigue siendo mayor que el tiempo default 
            {
                startTime -= finalTime;                                                      //el tiempo de spawn se ira reduciendo cada vez 
            }
        }
        else
        {
            timeBSpawn -= Time.deltaTime;                                                    //el tiempo de spawn llege a 0 
        }
    }
}
