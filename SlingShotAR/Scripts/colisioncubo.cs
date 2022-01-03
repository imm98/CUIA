


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class colisioncubo : MonoBehaviour
{
    // Start is called before the first frame update
    int contador1, contador2;
    public GameObject g;
    void Start()
    {
  
        contador1 = 0;
        contador2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Physics.gravity);
    }

    IEnumerator OnCollisionEnter(Collision col)
    {
        contador1++;
        Debug.Log(col.collider.name);
        if (col.gameObject.name == "Projectile(Clone)")
        {
            Debug.Log("Colision Detectada");
            /*GameObject planet = GameObject.FindGameObjectWithTag("Cube");*/
            g.GetComponent<Rigidbody>().useGravity = true;
            /*Physics.gravity = new Vector3(0, -9.81f, 0);*/
            
            yield return new WaitForSeconds(5);
            VGlobales.contador_disparos++;
            VGlobales.contador_disparos++;
            VGlobales.nivel++;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }


   
}