﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainscript : MonoBehaviour
{

    private int turno = 0;
    private Vector2 pos_inicial;

    // Start is called before the first frame update
    void Start()
    {
        pos_inicial = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void check_turn(int n_tecla){
        if(n_tecla == turno){
            turno ++;
        }
        else {
            GameObject.FindGameObjectWithTag("Player").transform.position=pos_inicial;
            turno=0;
        }
    }


}
