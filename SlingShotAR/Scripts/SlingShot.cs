using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


public class SlingShot : MonoBehaviour,IPointerDownHandler, IPointerUpHandler
{
    public Transform Projectile;
    public Transform DrawFrom;
    public Transform DrawTo;

    public SlingShotString slingshotString;
    public int NrDrawIncrements = 10;

    private Transform currentProjectile;

    private bool draw;
    private bool pulsar_izda;
    private bool pulsar_dcha;

    public UnityEvent OnHold;
    bool IsHolding;

    public void OnPointerDown(PointerEventData eventData)
    {
        IsHolding = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        IsHolding = false;
    }


    // Start is called before the first frame update
    void Start()
    {
        
        pulsar_izda = false;
        pulsar_dcha = false;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void pulsarBoton_izda()
    {
        DrawSlingShot(1);
        comprobarDisparos();
    }

    public void pulsarBoton_dcha()
    {
        ReleaseAndShoot(100);
        VGlobales.contador_disparos--;
    }
    public void ReleaseAndShoot(float shotForce)
    {
        draw = false;
        currentProjectile.transform.parent = null;
        Rigidbody projectileRigidBody = currentProjectile.GetComponent<Rigidbody>();
        projectileRigidBody.isKinematic = false;
        projectileRigidBody.AddForce((new Vector3(0,0.3f,-1)) * shotForce, ForceMode.Impulse);          //Cambiar la angulacion 
        currentProjectile.localScale = new Vector3(2f, 2f, 2f);
        slingshotString.CenterPoint = DrawFrom;
    }

    public void DrawSlingShot(float speed)
    {
        draw = true;
        currentProjectile = Instantiate(Projectile, DrawFrom.position, Quaternion.identity, transform);
        currentProjectile.forward = transform.forward;
        slingshotString.CenterPoint = currentProjectile.transform;

        float waitTimeBetweenDraws = speed / NrDrawIncrements;
        StartCoroutine(drawSlingShotWithIncrements(waitTimeBetweenDraws));
    }

    private IEnumerator drawSlingShotWithIncrements(float waitTimeBetweenDraws)
    {
        for (int i = 0; i < NrDrawIncrements; i++)
        {
            if (draw)
            {
                currentProjectile.transform.position = Vector3.Lerp(DrawFrom.position, DrawTo.position, (float)i / NrDrawIncrements);
                yield return new WaitForSeconds(waitTimeBetweenDraws);
            }
            else
            {
                i = NrDrawIncrements;
            }
        }
    }

    void comprobarDisparos()
    {
        if (VGlobales.contador_disparos <= 0)
        {
            SceneManager.LoadScene(11);
        }
    }

}
