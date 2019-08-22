using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamara : MonoBehaviour
{
    private float inputH;
    private  float inputV;
    private Quaternion final;

    void Awake()
    {

        

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
