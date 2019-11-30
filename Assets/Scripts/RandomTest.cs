using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTest : MonoBehaviour
{
    public int[] listaRandom;
    public int cantidadDeTeclas;
    void Start()
    {
        for(int i = 0; i<cantidadDeTeclas; i++)
        {
            listaRandom[i] = i;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
