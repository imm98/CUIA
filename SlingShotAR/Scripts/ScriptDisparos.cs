using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptDisparos : MonoBehaviour
{

    
    
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        
        score.text = VGlobales.contador_disparos.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = VGlobales.contador_disparos.ToString();
    }
}
