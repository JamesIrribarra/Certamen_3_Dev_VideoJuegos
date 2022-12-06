using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonesMovimiento : MonoBehaviour
{
    public float speed;
    private bool movDerecha;
    private bool movIzquierda;
    private bool movArriba;
    private bool movAbajo;


    private void Update()
    {
        
        if(movDerecha) 
        {
            transform.position = transform.position + (Vector3.right * speed * Time.deltaTime);
            
        }
        if (movDerecha == false)
        {
            transform.position = transform.position + (Vector3.right * 0 * Time.deltaTime);
        }
        if (movIzquierda)
        {
            transform.position = transform.position + (Vector3.left * speed * Time.deltaTime);
        }
        if (movIzquierda == false)
        {
            transform.position = transform.position + (Vector3.left * 0 * Time.deltaTime);
        }
        if (movAbajo)
        {
            transform.position = transform.position + (Vector3.back * speed * Time.deltaTime);
        }
        if (movAbajo == false)
        {
            transform.position = transform.position + (Vector3.back * 0 * Time.deltaTime);
        }
        if (movArriba)
        {
            transform.position = transform.position + (Vector3.forward * speed * Time.deltaTime);
        }
        if(movArriba == false)
        {
            transform.position = transform.position + (Vector3.forward * 0 * Time.deltaTime);
        }

    }
    
    public void ButtonDerecha()
    {
        movDerecha = true;
    }
    public void ButtonNoDerecha()
    {
        movDerecha = false;
    }
    public void ButtonIzquierda()
    {
        movIzquierda = true;
    }
    public void ButtonNoIzquierda()
    {
        movIzquierda = false;
    }
    public void ButtonArriba()
    {
        movArriba = true;
    }
    public void ButtonNoArriba()
    {
        movArriba = false;
    }
    public void ButtonAbajo()
    {
        movAbajo = true;
    }
    public void ButtonNoAbajo()
    {
        movAbajo = false;
    }

    
    //public void Clean()
    //{
    //    movAbajo = false;
    //    movArriba = false;
    //    movDerecha = false;
    //    movIzquierda = false;
    //}
}
