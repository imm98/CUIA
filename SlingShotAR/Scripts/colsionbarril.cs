


using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class colisionbarril : MonoBehaviour
{
    // Start is called before the first frame update
    int contador1, contador2;
    void Start()
    {
        contador1 = 0;
        contador2 = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        contador1++;
        Debug.Log(col.collider.name);
        if (col.gameObject.name == "Projectile")
        {
            Debug.Log("Colision Detectada");
        }
        Debug.Log(contador1 + "     " + contador2);
    }


    void OnTriggerEnter(Collider other)
    {
        contador2++;
        Debug.Log(contador1 + "     " + contador2);
    }

    void OnTriggerStay(Collider other)
    {
        contador2++;
        Debug.Log("Adios");
    }
}