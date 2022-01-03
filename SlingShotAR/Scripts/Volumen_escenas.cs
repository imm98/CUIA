using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volumen_escenas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioListener.volume = VGlobales.volumen;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
