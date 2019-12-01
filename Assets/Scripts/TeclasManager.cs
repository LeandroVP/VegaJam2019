using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeclasManager : MonoBehaviour
{
    public GameObject randomBox;
    public GameObject[] listaTeclas;
    void Start()
    {
        print("Tengo " + transform.childCount + " hijos");
        for (int i = 0; i<transform.childCount; i++)
        {
            listaTeclas[i] = GameObject.FindGameObjectsWithTag("Tecla")[i];
            listaTeclas[i].name = randomBox.GetComponent<RandomTest>().listaRandom[i].ToString();
            listaTeclas[i].gameObject.GetComponent<Activador>().numero = randomBox.GetComponent<RandomTest>().listaRandom[i];
        }
        
    }

    void Update()
    {
        
    }
}
