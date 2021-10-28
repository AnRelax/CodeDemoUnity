using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDiChuyen : MonoBehaviour
{
    public float BossSpeed;

    Rigidbody2D Boss;
    Animator BossCD;

    //bien Boss lat mat 
    public GameObject BossGraphic;
    bool quaymatphai = true;
    float quaymatTime = 2f;
    float Next = 0f;
    float dichuyen = 2;
    bool canFlip = true;

    // boss tan cong
    public Transform Ban;
    public GameObject MuiTen;
    float muiten = 1f;
    float next = 0;

    void Awake()
    {

        Boss = GetComponent<Rigidbody2D>();

        //lay con cua no
        BossCD = gameObject.GetComponent<Animator>();

    }

    void Start()
    {
       
    }

    
    void Update()
    {
        if (Time.time > Next)
        {
            Next = Time.time + quaymatTime;
            flip();
            
            randomDiChuyen();
           BossCD.SetBool("Run", false);
        }

    }

    void randomDiChuyen()
    {
        if (quaymatphai)
        {
            BossCD.SetBool("Run", true);
            Boss.velocity = new Vector2(((dichuyen+2) * BossSpeed), Boss.velocity.y);
           
            
        }
        else if (!quaymatphai)
        {
            BossCD.SetBool("Run", true);
            Boss.velocity = new Vector2(-((dichuyen +2) * BossSpeed), Boss.velocity.y);
           
               
       
        }
        
    }

    //boss quay sang nhin nhan vat chinh
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (quaymatphai && other.transform.position.x < transform.position.x)
            {
                
                flip();
            }
            else if (!quaymatphai && other.transform.position.x > transform.position.x)
            {
                
                flip();
            }
            canFlip = false;
            
        }
        else if (other.tag == "Player1")
        {
            if (quaymatphai && other.transform.position.x < transform.position.x)
            {

                flip();
            }
            else if (!quaymatphai && other.transform.position.x > transform.position.x)
            {

                flip();
            }
            canFlip = false;

        }
    }

    

    //boss ruoc nhan vat chinh khi di vao khu vuc cua boss
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (quaymatphai && other.transform.position.x > transform.position.x + 5)
            {
                BossCD.SetBool("Attack", true);
                Bullet();
                // Boss.velocity = new Vector2(dichuyen * BossSpeed, Boss.velocity.y);
                // Boss.AddForce(new Vector2(-1, 0) * BossSpeed);

            }
            else if (!quaymatphai && other.transform.position.x < transform.position.x -5)
            {
                BossCD.SetBool("Attack", true);
                Bullet();
                //BossCD.SetBool("Run", true);
                //Boss.velocity = new Vector2(-(dichuyen * BossSpeed), Boss.velocity.y);
                // Boss.AddForce(new Vector2(10, 0) * BossSpeed);

            }
            else if (quaymatphai && other.transform.position.x > transform.position.x - 2)
            {
                BossCD.SetBool("Run", true);
                Boss.velocity = new Vector2((dichuyen * BossSpeed), Boss.velocity.y);
                // Boss.AddForce(new Vector2(10, 0) * BossSpeed);

            }
            else if (!quaymatphai && other.transform.position.x < transform.position.x +2)
            {
                BossCD.SetBool("Run", true);
                Boss.velocity = new Vector2(-(dichuyen * BossSpeed), Boss.velocity.y);
                // Boss.AddForce(new Vector2(10, 0) * BossSpeed);

            }
            // BossCD.SetBool("Run", true);
            //BossCD.SetBool("Attack", true);
            if (dichuyen > 0 && !quaymatphai)
            {
                flip();
            }
            else if (dichuyen < 0 && quaymatphai)
            {
                flip();
            }
        }
        else if (other.tag == "Player1")
        {
            if (quaymatphai && other.transform.position.x > transform.position.x + 5)
            {
                BossCD.SetBool("Attack", true);
                Bullet();
                // Boss.velocity = new Vector2(dichuyen * BossSpeed, Boss.velocity.y);
                // Boss.AddForce(new Vector2(-1, 0) * BossSpeed);

            }
            else if (!quaymatphai && other.transform.position.x < transform.position.x - 5)
            {
                BossCD.SetBool("Attack", true);
                Bullet();
                //BossCD.SetBool("Run", true);
                //Boss.velocity = new Vector2(-(dichuyen * BossSpeed), Boss.velocity.y);
                // Boss.AddForce(new Vector2(10, 0) * BossSpeed);

            }
            else if (quaymatphai && other.transform.position.x > transform.position.x - 2)
            {
                BossCD.SetBool("Run", true);
                Boss.velocity = new Vector2((dichuyen * BossSpeed), Boss.velocity.y);
                // Boss.AddForce(new Vector2(10, 0) * BossSpeed);

            }
            else if (!quaymatphai && other.transform.position.x < transform.position.x + 2)
            {
                BossCD.SetBool("Run", true);
                Boss.velocity = new Vector2(-(dichuyen * BossSpeed), Boss.velocity.y);
                // Boss.AddForce(new Vector2(10, 0) * BossSpeed);

            }
            // BossCD.SetBool("Run", true);
            //BossCD.SetBool("Attack", true);
            if (dichuyen > 0 && !quaymatphai)
            {
                flip();
            }
            else if (dichuyen < 0 && quaymatphai)
            {
                flip();
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (quaymatphai && other.transform.position.x > transform.position.x + 5)
            {
                BossCD.SetBool("Attack", true);
                Bullet();
                // Boss.velocity = new Vector2(dichuyen * BossSpeed, Boss.velocity.y);
                // Boss.AddForce(new Vector2(-1, 0) * BossSpeed);

            }
            else if (!quaymatphai && other.transform.position.x < transform.position.x - 5)
            {
                BossCD.SetBool("Attack", true);
                Bullet();
                //BossCD.SetBool("Run", true);
                //Boss.velocity = new Vector2(-(dichuyen * BossSpeed), Boss.velocity.y);
                // Boss.AddForce(new Vector2(10, 0) * BossSpeed);

            }
            else if (quaymatphai && other.transform.position.x > transform.position.x - 2)
            {
                BossCD.SetBool("Run", true);
                Boss.velocity = new Vector2((dichuyen * BossSpeed), Boss.velocity.y);
                // Boss.AddForce(new Vector2(10, 0) * BossSpeed);

            }
            else if (!quaymatphai && other.transform.position.x < transform.position.x + 2)
            {
                BossCD.SetBool("Run", true);
                Boss.velocity = new Vector2(-(dichuyen * BossSpeed), Boss.velocity.y);
                // Boss.AddForce(new Vector2(10, 0) * BossSpeed);

            }

            canFlip = true;
        }
        else if (other.tag == "Player1")
        {
            if (quaymatphai && other.transform.position.x > transform.position.x + 5)
            {
                BossCD.SetBool("Attack", true);
                Bullet();
                // Boss.velocity = new Vector2(dichuyen * BossSpeed, Boss.velocity.y);
                // Boss.AddForce(new Vector2(-1, 0) * BossSpeed);

            }
            else if (!quaymatphai && other.transform.position.x < transform.position.x - 5)
            {
                BossCD.SetBool("Attack", true);
                Bullet();
                //BossCD.SetBool("Run", true);
                //Boss.velocity = new Vector2(-(dichuyen * BossSpeed), Boss.velocity.y);
                // Boss.AddForce(new Vector2(10, 0) * BossSpeed);

            }
            else if (quaymatphai && other.transform.position.x > transform.position.x - 2)
            {
                BossCD.SetBool("Run", true);
                Boss.velocity = new Vector2((dichuyen * BossSpeed), Boss.velocity.y);
                // Boss.AddForce(new Vector2(10, 0) * BossSpeed);

            }
            else if (!quaymatphai && other.transform.position.x < transform.position.x + 2)
            {
                BossCD.SetBool("Run", true);
                Boss.velocity = new Vector2(-(dichuyen * BossSpeed), Boss.velocity.y);
                // Boss.AddForce(new Vector2(10, 0) * BossSpeed);

            }

            canFlip = true;
        }
        Boss.velocity = new Vector2(0, 0);
        BossCD.SetBool("Run", false);
        BossCD.SetBool("Attack", false);
    }

    /*void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if (quaymatphai && other.transform.position.x < transform.position.x)
            {
                Boss.velocity = new Vector2(dichuyen * BossSpeed, Boss.velocity.y);
                // Boss.AddForce(new Vector2(-1, 0) * BossSpeed);
            }
            else if (!quaymatphai && other.transform.position.x > transform.position.x)
            {
                Boss.velocity = new Vector2(-(dichuyen * BossSpeed), Boss.velocity.y);
                // Boss.AddForce(new Vector2(10, 0) * BossSpeed);
            }

            canFlip = true;
        }
        Boss.velocity = new Vector2(0, 0);
        BossCD.SetBool("Run", false);
        BossCD.SetBool("Attack", false);
    }*/

    //boss quay mat tuong tu nhan vat chinh
    void flip()
    {
        if (!canFlip) // canFlip = False;
        {
            return;
        }
        quaymatphai = !quaymatphai;
        Vector3 theScale = BossGraphic.transform.localScale;
        //Vector3 theScale = transform.localScale;
        theScale.x = theScale.x * (-1);
        BossGraphic.transform.localScale = theScale;
        //transform.localScale = theScale;
    }
    void Bullet()
    {
        if (Time.time > next)
        {
            next = Time.time + muiten;
            if (quaymatphai)
            {
                Instantiate(MuiTen, Ban.position, Quaternion.Euler(new Vector3(1, 1, 0)));
            }
            else if (!quaymatphai)
            {
                Instantiate(MuiTen, Ban.position, Quaternion.Euler(new Vector3(1, 1, 180)));
            }
        }
    }

}
