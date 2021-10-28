using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Menu : MonoBehaviour
{
    //bat dau game
    public void StartGame()
    {
        Application.LoadLevel("ChonCapDo");
    }

    //cai dat game
    public void OptionMenu()
    {
        Application.LoadLevel("OptionMenu");
    }
    public void Exit()
    {
       // this.close();
        Application.LoadLevel("KetThucGame");
    }
    public void Gioithieugame()
    {
        // this.close();
        Application.LoadLevel("GioiThieuGame");
    }

    void Start()
    {
       // AmThanh.instance.PlaySound(AmThanh.instance.theme, 1, true);
    }

    
    void Update()
    {
        
    }
}
