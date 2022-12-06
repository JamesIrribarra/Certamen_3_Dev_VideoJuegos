using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{

    public InputField inputField;
    public Text textoNombre;
    public GameObject botonAceptar;
    public GameObject botonJugar;

    private void Update()
    {
        if(textoNombre.text.Length<5)
        {
            botonAceptar.SetActive(false);
            botonJugar.SetActive(false);
        }
        if(textoNombre.text.Length>=5)
        {
            botonAceptar.SetActive(true);
    
        }

    }

    public void aceptar()
    {
        PlayerPrefs.SetString("nombre1", inputField.text);
        Debug.Log("El nombre de playerprefs es:" + PlayerPrefs.GetString("nombre1"));
    }

}
