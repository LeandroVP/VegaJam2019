using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeclasManager : MonoBehaviour
{
    public GameObject randomBox;
    public GameObject[] listaTeclas;
    void Start()
    {
        for(int i = 0; i<transform.childCount; i++)
        {
            listaTeclas[i] = transform.GetChild(i).gameObject;
            listaTeclas[i].name = randomBox.GetComponent<RandomTest>().listaRandom[i].ToString();
        }
    }

    void Update()
    {
        
    }
}
