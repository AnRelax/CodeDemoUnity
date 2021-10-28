using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTheoNV : MonoBehaviour
{
    public Transform Theo;
    public float Chonggiat;

    Vector3 offset;

    float lowY;


    
    void Start()
    {
        offset = transform.position - Theo.position;
        lowY = transform.position.y;
    }

    
    void FixedUpdate()
    {
        Vector3 Theosau = Theo.position + offset;
        transform.position = Vector3.Lerp (transform.position, Theosau, Chonggiat * Time.deltaTime);

        /*khoa camera
         if (transform.position.y < lowY)
            transform.position = new Vector3(transform.position.x, lowY, transform.position.z);
         if (transform.position.y > lowY)
            transform.position = new Vector3(transform.position.x, lowY, transform.position.z);
        */
    }
}
