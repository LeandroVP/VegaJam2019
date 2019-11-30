using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    Rigidbody2D rb;
    float ejeX;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        ejeX = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3((ejeX * (Time.deltaTime * speed)) , 0, 0));       
    }
    private void FixedUpdate()
    {
        
    }

}
