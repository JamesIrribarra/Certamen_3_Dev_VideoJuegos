using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cargar_Name : MonoBehaviour
{
    private GameObject nombre1;

    private void Start()
    {
        nombre1 = GameObject.FindGameObjectWithTag("nombre1");
        nombre1.GetComponent <Text>().text = PlayerPrefs.GetString("nombre1");
    }
}
