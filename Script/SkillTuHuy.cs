using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTuHuy : MonoBehaviour
{
    public float timeTonTai;

    public float weaponDamage;

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

            if (other.gameObject.layer == LayerMask.NameToLayer("player"))
            {
                HPBossSatThu hurtEnemy = other.gameObject.GetComponent<HPBossSatThu>();
                hurtEnemy.addST(weaponDamage);

            }
            else if (other.gameObject.layer == LayerMask.NameToLayer("player1"))
            {

                HPThanChet hurtEnemyTC = other.gameObject.GetComponent<HPThanChet>();
                hurtEnemyTC.addSTThanChet(weaponDamage);
            }

        }
    }

}
