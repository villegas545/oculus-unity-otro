using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo2 : MonoBehaviour
{
    public Transform esferaa;
    //  public Transform esferab;
    public float tiempoentredisparo = 2.5f;
    private float siguientedisparo = 0f;
    public AudioSource controlaudio;
    public AudioClip sonidos;
    

    // Update is called once per frame
    void Update()
    {

        /*
        if (Input.GetKeyDown(KeyCode.A))
        {
            siguientedisparo = Time.time + tiempoentredisparo;
            Instantiate(esferaa, transform.position, transform.rotation);
            //controlaudio.clip = sonidos;
            //controlaudio.Play();
            //controlaudio.loop = false;

        }*/

        /* else if (Input.GetKeyDown(KeyCode.D))
         {
             siguientedisparo = Time.time + tiempoentredisparo;
             Instantiate(esferab, transform.position, transform.rotation);
             //ontrolaudio.clip = sonidos;
             //controlaudio.Play();
             //controlaudio.loop = false;

         }*/

        Debug.Log(Time.time);
        Debug.Log(siguientedisparo);
        if ((Input.GetButtonDown("Fire1") || OVRInput.Get(OVRInput.Button.PrimaryTouchpad) || Input.touchCount > 0) && Time.time > siguientedisparo)
        {
            
            siguientedisparo = Time.time + tiempoentredisparo;
            Instantiate(esferaa, transform.position, transform.rotation);
        }
        }
}
