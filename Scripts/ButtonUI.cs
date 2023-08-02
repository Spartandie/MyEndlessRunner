using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUI : MonoBehaviour
{
    [SerializeField] private GameObject[] Buttons;
    [SerializeField] AudioSource click;


    public void Pausa(){
        Time.timeScale = 0f;
        Buttons[0].SetActive(true);
        Buttons[1].SetActive(true);
        Buttons[2].SetActive(true);
        //gameObject.SetActive(false);
    }

    public void Continuar(){
        Time.timeScale = 1f;
        Buttons[0].SetActive(false);
        Buttons[1].SetActive(false);
        Buttons[2].SetActive(false);
    }

    public void Reiniciar(){
        Time.timeScale = 1f;
    }

     public void Menu(){
        Time.timeScale = 1f;
    }

    public void clickSFX(){
        click.Play();
    }

}
