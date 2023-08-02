using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScore : MonoBehaviour
{
    [SerializeField] GameObject puntaje;

    public void ResetS(){
        PlayerPrefs.SetInt("HighScore", 0);
        puntaje.SetActive(true);
        StartCoroutine(WaitAndDoSomething());
    }
    
    private IEnumerator WaitAndDoSomething(){
        yield return new WaitForSeconds(1.0f);
        puntaje.SetActive(false);
    }
}
