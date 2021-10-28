using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTuHuy : MonoBehaviour
{
    public float timeTonTai;

    public float weaponDamage;
    


    void Start()
    {
        Destroy(gameObject, timeTonTai);
    }

    
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        //mui ten cham vat thi bien mat
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Dat")
        {
            Destroy(gameObject);

            if (other.gameObject.layer == LayerMask.NameToLayer("nhanvat"))
            {
                HPXaThu hurtEnemy = other.gameObject.GetComponent<HPXaThu>();
                hurtEnemy.addDame(weaponDamage);
            }

        }
        else if (other.gameObject.tag == "Player1" || other.gameObject.tag == "Dat")
        {
            Destroy(gameObject);

            if (other.gameObject.layer == LayerMask.NameToLayer("nhanvat"))
            {
                HPSatThu hurtEnemy = other.gameObject.GetComponent<HPSatThu>();
                hurtEnemy.addDame(weaponDamage);
            }

        }
    }
}
