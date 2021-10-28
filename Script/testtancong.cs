using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testtancong : MonoBehaviour
{
    Animator am;
    const int tancong = 1;
    const int dungyen =2;
    const string adm = "ChuyenDoi";

    // Start is called before the first frame update
    void Start()
    {
        am = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            am.SetInteger(adm, tancong);
        }else
        {
            am.SetInteger(adm, dungyen);
        }
    }
}
