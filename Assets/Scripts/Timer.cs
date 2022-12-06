using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    [SerializeField] int min, seg;
    [SerializeField] Text tiempo;
    public string sceneName;
    private bool enMarcha;
    private float restante;

    //public GameObject partes;


    private void Awake()
    {
        restante = (min * 60) + seg;
        enMarcha = true;
    }
    private void Update()
    {
        if (enMarcha)
        {
            restante -= Time.deltaTime;
            if (restante < 1)
            {
                enMarcha = true;
                SceneManager.LoadScene(sceneName);
                //perdiste
            }
            int tempMin = Mathf.FloorToInt(restante / 60);
            int temSeg = Mathf.FloorToInt(restante % 60);
            tiempo.text = string.Format("{00:00}:{01:00}", tempMin, temSeg);
        }
    }

}
