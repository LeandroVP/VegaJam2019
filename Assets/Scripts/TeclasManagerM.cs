using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeclasManagerM : MonoBehaviour
{
    public GameObject randomBox;
    public GameObject[] listaTeclas;
    public GameObject Tecla;
    void Start()
    {
        //int nuevos = Random.Range(2,8);
        int nuevos = 5;

        Vector2 nuevaPos = new Vector2(-0.6f, -1f);
        Vector2 espaciado = new Vector2(1.6f, 0f);
        //GameObject Tecla = GameObject.FindGameObjectWithTag("Tecla");
    
        for(int i=0;i<nuevos;i++)
        {
            nuevaPos+=espaciado;
            Instantiate(Tecla, nuevaPos, Quaternion.identity, transform);
        }
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
