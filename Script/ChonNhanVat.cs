using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChonNhanVat : MonoBehaviour
{
    public void Satthu()
    {
        Application.LoadLevel("SampleScene");
    }

    public void XaThu()
    {
        Application.LoadLevel("mhNVxathu");
    }

    // Start is called before the first frame update
    void Start()
    {
        
        AmThanh.instance.PlaySound(AmThanh.instance.theme, 1, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
