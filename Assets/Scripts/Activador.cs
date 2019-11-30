using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activador : MonoBehaviour
{
    public int numero;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("REPRODUZCO LA NOTA" + numero);
            if(Movimiento.activable == true)
            {
                Debug.Log("ACTIVO LA NOTA" + numero);
            }
        }
    }
}
