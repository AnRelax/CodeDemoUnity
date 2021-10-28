using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ThunderBayRa : MonoBehaviour
{
    public float Speed;
    public GameObject BossGraphic;
    Rigidbody2D myBody;



    void Awake()
    {

        myBody = GetComponent<Rigidbody2D>();

        //luc day vien dan bay di
        if (transform.localRotation.z > 0)
        {
            Vector3 theScale = BossGraphic.transform.localScale;
            myBody.AddForce(new Vector2(-1, 0) * Speed, ForceMode2D.Impulse);
            theScale.y = theScale.y * (-1);
            BossGraphic.transform.localScale = theScale;
        }
        else
        {
            myBody.AddForce(new Vector2(1, 0) * Speed, ForceMode2D.Impulse);
        }

    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
