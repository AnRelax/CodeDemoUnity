using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DiChuyen : MonoBehaviour
{
    public float maxSpeed;
    public float jump;
    bool quayMatsangphai;
    bool Xacdinhjum;

    Rigidbody2D myBody;
    Animator myAmin;

    //cac bien de ban
    public Transform Ban;
    public GameObject MuiTen;
    float muiten = 0.3f;
    float next = 0;

    void Start()
    {
        //AmThanh.instance.PlaySound(AmThanh.instance.theme, 2, true);
        myBody = GetComponent<Rigidbody2D> ();
        myAmin = GetComponent<Animator>();
        
        quayMatsangphai = true;
    }

    
    void FixedUpdate()
    {
        //di chuyen sang phai tri so la 1 , trai la -1, dung yen tri so la 0
        float dichuyen = Input.GetAxis("Horizontal");
        

        //chuyen trang thai tu dung yen sang di chuyen
        myAmin.SetFloat("Speed", Mathf.Abs(dichuyen));
        

        //di chuyen khoa truc toa do y de nhan vat k di chuyen len
        myBody.velocity = new Vector2(dichuyen * maxSpeed, myBody.velocity.y);

        if(dichuyen>0 &&!quayMatsangphai)
        {
            flip();
        }else if(dichuyen<0 && quayMatsangphai)
        {
            flip();
        }

        //kiem tra nhay len
        if (Input.GetKey (KeyCode.Space))
        {
            if (Xacdinhjum)
            {
                Xacdinhjum = false;
                myBody.velocity = new Vector2(myBody.velocity.x, jump);
            }
        }

        //kiem tra tan cong
        if (Input.GetAxisRaw("Fire1") > 0)
        {

            Bullet();
        }
    }

    //chuc nang chem ra skill
    void Bullet()
    {
        AmThanh.instance.PlaySound(AmThanh.instance.menu, 1f);
        if (Time.time > next)
        {
            next = Time.time + muiten;
            if (quayMatsangphai)
            {
                Instantiate(MuiTen, Ban.position, Quaternion.Euler(new Vector3(1, 1, 0)));
            }
            else if (!quayMatsangphai)
            {
                Instantiate(MuiTen, Ban.position, Quaternion.Euler(new Vector3(1, 1, 180)));
            }
        }
    }

    void flip()
    {
        quayMatsangphai = !quayMatsangphai;

        //toa do hien tai cua nhan vat
        Vector3 theScale = transform.localScale;

        //su dung toa do x ,lat mat nguoc lai
        theScale.x = theScale.x * (-1) ;
        transform.localScale = theScale;
    }

    //va cham 2 vat the giua nhan vat va mat dat
    void OnCollisionEnter2D(Collision2D other)
    {
        //nguoi choi va cham vs dat thi se duoc phep nhay len
        if(other.gameObject.tag == "Dat")
        {
            Xacdinhjum = true;
        }
    }
}
