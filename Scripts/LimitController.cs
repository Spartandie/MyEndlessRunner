using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitController : MonoBehaviour
{
    [SerializeField] float velocidad = 1f;
    float incrementoV = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }

    [SerializeField] void Movimiento(){
        if(velocidad<16f){
            velocidad += incrementoV;
        }
        transform.position += transform.right * Time.deltaTime * velocidad;

    }
}
