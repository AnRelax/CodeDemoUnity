using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public void Restart()
    {
        Application.LoadLevel("mhNVxathu");
    }

    public void Menu()
    {
        Application.LoadLevel("MainMenu");
    }

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
