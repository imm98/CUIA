


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;



public class colision3objetos2 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject h;
    public GameObject t;
    public GameObject u;
    private Vector3 c1;
    private Vector3 c2;
    private Vector3 c3;

    void Start()
    {
        VGlobales.choque1 = 0;
        VGlobales.choque2 = 0;
        VGlobales.choque3 = 0;
        c1 = h.transform.position;
        c2 = t.transform.position;
        c3 = u.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Physics.gravity);
    }

    IEnumerator OnCollisionEnter(Collision col)
    {

        Debug.Log(col.collider.name);
        if (1 == 1)
        {
            Debug.Log("Colision Detectada2");
            /*GameObject planet = GameObject.FindGameObjectWithTag("Cube");*/
            Vector3 aux1 = h.transform.position;
            Vector3 aux2 = t.transform.position;
            Vector3 aux3 = u.transform.position;


            float dist1 = Vector3.Distance(aux1, c1);
            float dist2 = Vector3.Distance(aux2, c2);
            float dist3 = Vector3.Distance(aux3, c3);

            if (dist2 > 0.5)
                t.GetComponent<Rigidbody>().useGravity = true;

            VGlobales.choque2 = 1;


            if ((VGlobales.choque1 == 1) && (VGlobales.choque2 == 1) && (VGlobales.choque3 == 1))
            {
                Debug.Log("Funcionaaa");
                VGlobales.choque1 = 0;
                VGlobales.choque2 = 0;
                VGlobales.choque3 = 0;

                yield return new WaitForSeconds(5);
                VGlobales.contador_disparos++;
                VGlobales.contador_disparos++;
                VGlobales.nivel = (VGlobales.nivel + 4);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

        }

    }

    /*public bool informacionChoque()
     {
         return choque1;
     }*/

    IEnumerator cambiarEscena()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }



}
