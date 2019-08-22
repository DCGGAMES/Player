using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamara : MonoBehaviour
{
    private float inputH;
    private  float inputV;
    private float speed;
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
        final = Quaternion.Euler(-inputV, inputH, 0);
        transform.localRotation = final;

    }
   
}
