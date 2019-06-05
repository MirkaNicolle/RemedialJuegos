using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPoint : MonoBehaviour {

    public GameObject Obstacle;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Obstacle, transform.position, Quaternion.identity);   //instancia del objeto 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
