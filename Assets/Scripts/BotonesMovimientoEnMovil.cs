using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonesMovimientoEnMovil : MonoBehaviour
{
    public float Mspeed;
    private bool MmovDerecha;
    private bool MmovIzquierda;
    private bool MmovArriba;
    private bool MmovAbajo;


    private void Update()
    {

        if (MmovDerecha)
        {
            transform.position = transform.position + (Vector3.right * Mspeed * Time.deltaTime);

        }
        if (MmovDerecha == false)
        {
            transform.position = transform.position + (Vector3.right * 0 * Time.deltaTime);
        }
        if (MmovIzquierda)
        {
            transform.position = transform.position + (Vector3.left * Mspeed * Time.deltaTime);
        }
        if (MmovIzquierda == false)
        {
            transform.position = transform.position + (Vector3.left * 0 * Time.deltaTime);
        }
        if (MmovAbajo)
        {
            transform.position = transform.position + (Vector3.down * Mspeed * Time.deltaTime);
        }
        if (MmovAbajo == false)
        {
            transform.position = transform.position + (Vector3.down * 0 * Time.deltaTime);
        }
        if (MmovArriba)
        {
            transform.position = transform.position + (Vector3.up * Mspeed * Time.deltaTime);
        }
        if (MmovArriba == false)
        {
            transform.position = transform.position + (Vector3.up * 0 * Time.deltaTime);
        }

    }

    public void MButtonDerecha()
    {
        MmovDerecha = true;
    }
    public void MButtonNoDerecha()
    {
        MmovDerecha = false;
    }
    public void MButtonIzquierda()
    {
        MmovIzquierda = true;
    }
    public void MButtonNoIzquierda()
    {
        MmovIzquierda = false;
    }
    public void MButtonArriba()
    {
        MmovArriba = true;
    }
    public void MButtonNoArriba()
    {
        MmovArriba = false;
    }
    public void MButtonAbajo()
    {
        MmovAbajo = true;
    }
    public void MButtonNoAbajo()
    {
        MmovAbajo = false;
    }
}
