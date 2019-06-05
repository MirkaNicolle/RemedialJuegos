using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class player : MonoBehaviour {

    public Vector2 pos;
    public float Y;
    public float speed;
    public float max;
    public float min;
    public int health = 5;
    public Animator camAnim;
    public Text healthText; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = health.ToString();                                                         //muestra la salud

        if (health <= 0)
        {
            SceneManager.LoadScene("Menu");                                                         //cuando muere, vuelve al menu
        }
        transform.position = Vector2.MoveTowards(transform.position, pos, speed * Time.deltaTime);  //moviento libre  

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < max)                        //verifica que el movimento sea menor que el máximo
        {
            camAnim.SetTrigger("shake");                                                            //movimiento de pantalla
            pos = new Vector2(transform.position.x, transform.position.y + Y);                      //movimiento hacia arriba
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > min)                 //verifica que el movimento sea mayor que el mínimo
        {
            camAnim.SetTrigger("shake");                                                            //movimiento de pantalla
            pos = new Vector2(transform.position.x, transform.position.y - Y);                      //movimiento hacia abajo
        }

    }
}
