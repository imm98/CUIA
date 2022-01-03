using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;



public class bomba2 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject h;

    private Vector3 c1;


    void Start()
    {
        VGlobales.bomba2 = 0;
        c1 = h.transform.position;

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
            Debug.Log("Colision Detectada Bomba 2");
            /*GameObject planet = GameObject.FindGameObjectWithTag("Cube");*/
            Vector3 aux1 = h.transform.position;



            float dist1 = Vector3.Distance(aux1, c1);


            if (dist1 > 0.5)
                h.GetComponent<Rigidbody>().useGravity = true;

            yield return new WaitForSeconds(5);
            if (VGlobales.bomba2 == 0)
            {
                VGlobales.contador_disparos = (VGlobales.contador_disparos - 5);
                VGlobales.bomba2 = 1;
            }





        }


    }

    /*public bool informacionChoque()
     {
         return choque1;
     }*/




}
