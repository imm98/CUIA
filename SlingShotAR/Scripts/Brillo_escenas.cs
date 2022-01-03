using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Brillo_escenas : MonoBehaviour
{
    public Image panelBrillo;
    // Start is called before the first frame update
    void Start()
    {
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, VGlobales.brillo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
