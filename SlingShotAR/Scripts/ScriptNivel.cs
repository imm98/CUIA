using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptNivel : MonoBehaviour
{
    // Start is called before the first frame update



    public Text score;
    private string salida;
    // Start is called before the first frame update
    void Start()
    {
        salida="Nivel: "+ VGlobales.nivel.ToString();
        score.text = salida;
    }

    // Update is called once per frame
    void Update()
    {
        salida = "Nivel: " + VGlobales.nivel.ToString();
        score.text = salida;
    }
}
