using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainscript : MonoBehaviour
{

    private int turno = 0;
    private Transform pos_inicial;

    // Start is called before the first frame update
    void Start()
    {
        pos_inicial = GameObject.FindGameObjectsWithTag("Player")[0].transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void check_turn(int n_tecla){
        if(n_tecla == turno){
            turno ++;
        }
        else {
            GameObject.FindGameObjectsWithTag("Player")[0].transform=pos_inicial;
            turno=0;
        }
    }


}
