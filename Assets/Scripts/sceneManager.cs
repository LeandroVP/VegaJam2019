﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Iniciar(){
        Application.LoadLevel("LeandroSandbox2");
    }

    public void Salir(){
        Application.Quit();
    }
}