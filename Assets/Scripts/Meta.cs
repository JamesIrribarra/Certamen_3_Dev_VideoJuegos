using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{
    public string sceneName;

    private void OnTriggerEnter(Collider other)
    {      
            SceneManager.LoadScene(sceneName);       
    }
}
