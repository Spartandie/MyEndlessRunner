using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class PuntajeDemo : MonoBehaviour
{

    [SerializeField] GameObject jugador;

    [SerializeField] Text HighScore;
    [SerializeField] Text puntaje; //Variable de texto que indica puntaje
    [SerializeField] Text CantidadMonedas; //Variable de texto que indica monedas recogidas
    [SerializeField] AudioSource coinSFX; //Sonido de moneda

    //Variables para realizar la recoleccion de monedas
    //[SerializeField] GameObject OroM;//Obejtomonedas
    int Monedas = 0; //Monedas recolectadas


    // Start is called before the first frame update
    void Start()
    {
        HighScore.text = "Puntaje Record: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
        CantidadMonedas.text = "Monedas: " + PlayerPrefs.GetInt("uwu", 0).ToString();
    }


      // Update is called once per frame
    void Update()
    {
        //El puntaje esta dado por la posicion del jugador en el juego
        puntaje.text = "Puntaje: " + Mathf.Floor(transform.position.x + 9);
        CantidadMonedas.text = "" +  Monedas;
        if( (transform.position.x + 9) > PlayerPrefs.GetInt("HighScore", 0)) {
            PlayerPrefs.SetInt("HighScore", (int)(transform.position.x + 9));
            HighScore.text = "Puntaje record: " + Mathf.Floor(transform.position.x + 9);
        }
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Moneda"){
            Monedas++;
            PlayerPrefs.SetInt("uwu", Monedas);
            Destroy(collision.gameObject);
            coinSFX.Play();
        }
    }
}
