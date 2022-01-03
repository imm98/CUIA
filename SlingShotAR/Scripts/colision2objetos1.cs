


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;



public class colision2objetos1 : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject h;
    public GameObject t;
    private Vector3 c1;
    private Vector3 c2;

    void Start()
    {
        VGlobales.choque1 = 0;
        VGlobales.choque2 = 0;
        c1 = h.transform.position;
        c2 = t.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        
        Debug.Log("Choque1"+ VGlobales.choque1);
        Debug.Log("Choque2" + VGlobales.choque2);
    }

    IEnumerator OnCollisionEnter(Collision col)
    {
       
        Debug.Log(col.collider.name);
        if (1==1)
        {
            Debug.Log("Colision Detectada");
            /*GameObject planet = GameObject.FindGameObjectWithTag("Cube");*/
            Vector3 aux1 = h.transform.position;
            Vector3 aux2 = t.transform.position;

            float dist1 = Vector3.Distance(aux1, c1);
            float dist2 = Vector3.Distance(aux2, c2);

            if (dist1>0.5)
                h.GetComponent<Rigidbody>().useGravity = true;

            VGlobales.choque1 = 1;
            /*Physics.gravity = new Vector3(0, -9.81f, 0);*/
            
            if ((VGlobales.choque1==1) && (VGlobales.choque2==1))
            {
                
                VGlobales.choque2=0;
                VGlobales.choque1=0;
                Debug.Log("Funcionaaah");
                VGlobales.contador_disparos++;
                VGlobales.contador_disparos++;
                VGlobales.nivel = (VGlobales.nivel + 2);
                yield return new WaitForSeconds(5);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            }
                
        }

    }


    IEnumerator cambiarEscena()
    {
        Debug.Log("LLegaa");
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    
  
}