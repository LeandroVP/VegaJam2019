using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D conQuienChoco)
    {
        print(conQuienChoco.transform.name);
        Destroy(conQuienChoco.gameObject);
    }
}
