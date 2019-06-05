using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour {

    public int damage = 1;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);  //movimiento en x
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<player>().health -= damage;               //daña al player
            other.GetComponent<player>().camAnim.SetTrigger("shake");    //movimiento de pantalla
            Debug.Log(other.GetComponent<player>().health);              //muestra la salud
            Destroy(gameObject);                                         //el objeto se destruye
        }
    }
}
