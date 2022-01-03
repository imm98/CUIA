using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class script_salto_nivel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Llega");
        cambiarEscena();
    }

    // Update is called once per frame
    void Update()
    {
        /* Debug.Log("Holaaaaa");
         yield return new WaitForSeconds(5);
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);*/
    }
    IEnumerator cambiarEscena()
    {
        Debug.Log("Holaaaaa");

        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator OnCollisionEnter(Collision col)
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
