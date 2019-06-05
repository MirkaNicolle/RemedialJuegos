using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class menu : MonoBehaviour {

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadScene(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);   //cambia de escena
    }
    public void Close()
    {
        Application.Quit();                    //cierra la aplicación
    }
}
