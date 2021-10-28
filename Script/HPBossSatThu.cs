using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBossSatThu : MonoBehaviour
{

    public float MaxHP;
    float HPHienTai;
    float bien = 1.5f;
    Animator am;

    const int chet = 1;
    const string adm = "Chet";

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

    
    void Update()
    {
        
    }
    public void addST(float dame)
    {
        SliderHealth.gameObject.SetActive(true);
        //giam mau hien tai khi nhan vao sat thuong 
        HPHienTai = HPHienTai - dame;
        SliderHealth.value = HPHienTai;

        if (HPHienTai <= 0)
        {
            am.SetInteger(adm, chet);

            Dead();
            Application.LoadLevel("SatThuChienThang");
        }
    }

    void Dead()
    {
        Destroy(gameObject, bien);
    }

}
