using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamara : MonoBehaviour
{
    private float inputH;
    private  float inputV;
    private float speed;
    private Quaternion comprovador;
    private Vector3 sig;
    private Vector3 act;
    private Quaternion final;

    void Awake()
    {

        act = new Vector3(transform.rotation.x, transform.rotation.y, 0);

    }
   
    void Start()
    {
       
    }

 
    void Update()
    {
        
        inputH = Input.mousePosition.x;
        inputV = Input.mousePosition.y;
        comprovador = Quaternion.Euler(-inputV, inputH, 0);
        sig = new Vector3(comprovador.x, comprovador.y, 0);
        final = comprovador;
      
        transform.localRotation = final;

    }
    private void ConversorGrados()
    {
       act.y += inputH * speed;
       act.x += inputV * speed;
    }
}
