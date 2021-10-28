using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VienDanTuHuy : MonoBehaviour
{
    public float timeTonTai;

    public float weaponDamage;

   // public GameObject bulletExplosion;

    

   // projectileController myPC;


    /*void Awake()
    {
        myPC = GetComponentInParent<projectileController>();

    }*/

    void Start()
    {
        Destroy(gameObject, timeTonTai);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter2D(Collision2D other)
     {
         //mui ten cham vat thi bien mat
         if (other.gameObject.tag == "Dat")
         {
             Destroy(gameObject);

             if(other.gameObject.layer == LayerMask.NameToLayer("player"))
             {
                 HPBoss hurtEnemy = other.gameObject.GetComponent<HPBoss>();
                 hurtEnemy.addDame(weaponDamage);
             }
            
        }
     }

    /*void OnTriggerEnter2D(Collider other)
    {
        if (other.gameObject.tag == "Dat")
        {
            Destroy(gameObject);

            if(other.gameObject.layer == LayerMask.NameToLayer("player"))
            {
                HPBoss hurtEnemy = other.gameObject.GetComponent<HPBoss>();
                hurtEnemy.addDame(weaponDamage);
            }
        }
    }*/

    /*void OnTriggerStay2D(Collider other)
    {
        if (other.gameObject.tag == "Dat")
        {
            Destroy(gameObject);

            if (other.gameObject.layer == LayerMask.NameToLayer("player"))
            {
                HPBoss hurtEnemy = other.gameObject.GetComponent<HPBoss>();
                hurtEnemy.addDame(weaponDamage);
            }
        }
    }*/

    /*void OnTriggerStay2D(Collider other)
    {
        if (other.gameObject.tag == "Boss")
        {
            myPC.removeForce();
            InStantiate(bulletExplosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }*/

}
