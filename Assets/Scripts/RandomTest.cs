using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTest : MonoBehaviour
{
    public int[] listaRandom;
    int cantidadDeTeclas;

    void Awake()
    {
        int anterior;
        cantidadDeTeclas = listaRandom.Length;
        anterior = cantidadDeTeclas - 1;
        for(int i = 0; i<anterior; i++)
        {
            var randomN = Random.Range(i, cantidadDeTeclas);
            var tmp = listaRandom[i];
            listaRandom[i] = listaRandom[randomN];
            listaRandom[randomN] = tmp;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
