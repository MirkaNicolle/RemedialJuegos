using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour {

    public float lifetime;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifetime);             //destruye los objetos ya no utilizados
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
