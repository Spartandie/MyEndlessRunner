using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DestroyerController : MonoBehaviour
{

    [SerializeField] float velocidad = 1f;
    float incrementoV = 0.001f;
    //GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }

    [SerializeField] void Movimiento(){
        if(velocidad<14f && Time.timeScale != 0){
            velocidad += incrementoV;
        }
        transform.position += transform.right * Time.deltaTime * velocidad;

    }

    /*
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Suelo"){
            Destroy(collision.gameObject);
            Debug.Log("colisioooon");
        }
    }

    */

    void OnCollisionEnter2D(Collision2D collision){
        //if(collision.gameObject.tag == "Suelo") {
            Destroy(collision.gameObject);
        //}
    }

}
