using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerControllerDemo : MonoBehaviour
{


    [SerializeField] GameObject player;
    [SerializeField] float velocidad = 1f;
    float incrementoV = 0.001f;

    [SerializeField] float FuerzaSalto;

    bool EnPiso = true;

    [SerializeField] Animator animator;

    [SerializeField] AudioSource jumpSFX;




    // Start is called before the first frame update
    void Start()
    {
        animator =GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        Saltar();
    }

    [SerializeField] void Movimiento(){
        if(velocidad<15f && Time.timeScale != 0){
            velocidad += incrementoV;
        }
        transform.position += transform.right * Time.deltaTime * velocidad;

    }

    void Saltar(){
        if(Input.GetKeyDown(KeyCode.Space) && EnPiso == true){
            Salto();
        }
        
    }

    [SerializeField] void Salto(){
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * FuerzaSalto, ForceMode2D.Impulse);
        EnPiso=false;
        animator.SetTrigger("SaltoT");
        animator.SetBool("Correr", false);
        jumpSFX.Play();
    }


    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Suelo"){
            EnPiso = true;
            animator.SetBool("Correr", true);
        }

        if(collision.gameObject.tag == "Enemy"){
            //Destroy(Player);
            //SceneManager.LoadScene("Demo");
            SceneManager.LoadScene("DeathScene");

        }
    }
}
