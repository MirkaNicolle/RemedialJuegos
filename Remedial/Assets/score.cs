using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour {

    public int p;
    public Text ptext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ptext.text = p.ToString();                      //muestra el score en pantalla
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        p++;                                           //incremento de 1 en el contador
        Destroy(other.gameObject);
    }

}
