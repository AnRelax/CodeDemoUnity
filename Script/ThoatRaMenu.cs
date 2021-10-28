using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThoatRaMenu : MonoBehaviour
{



    public void ExitMenu()
    {
        Application.LoadLevel("MainMenu");
    }
    // Start is called before the first frame update
    void Start()
    {
       // AmThanh.instance.PlaySound(AmThanh.instance.theme, 2, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
