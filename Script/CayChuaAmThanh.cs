using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CayChuaAmThanh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       AmThanh.instance.PlaySound(AmThanh.instance.theme, 0.5f, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
