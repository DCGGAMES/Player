using UnityEngine;
using System.Collections;
using System;



public class Player: MonoBehaviour
{

    private float Range = 1.0f;
    public float speed = 15.0F; 
    public int jumpSpeed = 1; 
    private bool saltando = false;
    public float Angulo = 80.0f;
    private bool caminando = false;
    private bool activo = false;
    

    void Awake()
    {

        


    }

    void Start()
    {
      
        Cursor.visible = false;



    }
    void Update()
    {

        if (Input.GetKey(KeyCode.Q))
        {
            speed = 5.0F;

        }
        else
        {
          
            speed = 3.0F;
        }

        Move(speed, jumpSpeed, saltando);
       

       

    }




    public void Move(float speed, float jumpSpeed, Boolean Saltando)
    {


      
       

        if (Input.GetKey(KeyCode.W))
        {


            transform.Translate(Vector3.forward * speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.S))
        {

            transform.Translate(Vector3.back * speed * Time.deltaTime);
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);

          
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            


        }
        if (Input.GetKeyUp(KeyCode.Space))
        {


            saltando = true;


            transform.Translate(transform.up * jumpSpeed);

            if (Input.GetKeyUp(KeyCode.Space) && saltando)
            {
                transform.Translate(transform.up * jumpSpeed);


            }

            
        }



        


    }
    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "suelo")
        {
            caminando = true;

        }
    }
    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "suelo")
        {
            caminando = false;


        }

    }

}
