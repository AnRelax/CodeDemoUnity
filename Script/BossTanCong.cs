using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTanCong : MonoBehaviour
{
    public float Damage;
    float dame = 0.5f;
    public float BiSatThuong;

    float NextDamage;

    

    void Start()
    {
        NextDamage = 0f;
    }

    
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.tag == "Player" && NextDamage < Time.time)
        {
            HPXaThu hpxathu = other.gameObject.GetComponent<HPXaThu>();
            hpxathu.addDame(Damage);
            NextDamage = dame + Time.time;

            pushBack(other.transform);
        }
        if (other.gameObject.tag == "Player1" && NextDamage < Time.time)
        {
            HPSatThu hpxathu = other.gameObject.GetComponent<HPSatThu>();
            hpxathu.addDame(Damage);
            NextDamage = dame + Time.time;

            pushBack(other.transform);
        }
    }
    void pushBack(Transform pushedObject)
    {
        Vector2 push = new Vector2((pushedObject.position.x - transform.position.x), (pushedObject.position.y - transform.position.y)).normalized;
        push *= BiSatThuong;
        Rigidbody2D bay = pushedObject.gameObject.GetComponent<Rigidbody2D>();
        bay.velocity = Vector2.zero;
        bay.AddForce(push, ForceMode2D.Impulse);
    }
}
