using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPSatThu : MonoBehaviour
{
    public float MaxHP;
    float HPHienTai;

    float bien = 1.3f;
    Animator am;

    const int chet = 1;
    const string adm = "chetluon";

    //bien UI
    public Slider SliderHealth;

    void Start()
    {
        
        HPHienTai = MaxHP;
        am = gameObject.GetComponent<Animator>();

        //bang gia tri value trong UI
        SliderHealth.maxValue = MaxHP;
        SliderHealth.value = MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addDame(float dame)
    {
        if (dame <= 0)
        {
            return;
        }
        //giam mau hien tai khi nhan vao sat thuong
        HPHienTai = HPHienTai - dame;
        SliderHealth.value = HPHienTai;

        if (HPHienTai <= 0)
        {

           // am.SetInteger(adm, chet);

           // Dead();

            //Waiter();
            Application.LoadLevel("ChoilaiSatThu");
        }
    }
    void Dead()
    {
        Destroy(gameObject, bien);
    }
}
