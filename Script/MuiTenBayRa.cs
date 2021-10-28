using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuiTenBayRa : MonoBehaviour
{
    public float Speed;

    Rigidbody2D myBody;

    

    void Awake()
    {

        myBody = GetComponent<Rigidbody2D>();

        //luc day vien dan bay di
        if (transform.localRotation.z > 0)
        {
            myBody.AddForce(new Vector2(-1, 0) * Speed, ForceMode2D.Impulse);
        }
        else
        {
            myBody.AddForce(new Vector2(1, 0) * Speed, ForceMode2D.Impulse);
        }
         
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
   
}
