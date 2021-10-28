using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChonMucDo : MonoBehaviour
{
    public void De()
    {
        Application.LoadLevel("ChonNhanVat");
    }
    public void Thuong()
    {
        Application.LoadLevel("ChonNhanVat");
    }
    public void Kho()
    {
        Application.LoadLevel("ChonNhanVat");
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
