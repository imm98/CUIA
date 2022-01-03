using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFinal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        VGlobales.nivel = 1;
        VGlobales.contador_disparos = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAgain()
    {
        
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }


    public void CerrarJuego()
    {
        Application.Quit();
        Debug.Log("Salir");
    }
}
