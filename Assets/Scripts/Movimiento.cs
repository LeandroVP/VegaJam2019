using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    Rigidbody2D rb;
    float ejeX;
    public float speed;
    public float jumpForce;
    public float distanciaRaycast;
    public LayerMask mascara;
    float keyVelocity;
    float currentVelocity;
    public static bool activable = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentVelocity = 0;
    }

    void Update()
    {
        ejeX = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3((ejeX * (Time.deltaTime * speed)) , 0, 0));      
    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit2D rHit = Physics2D.Raycast(transform.position + new Vector3(0.5f,0,0), Vector2.down, distanciaRaycast, mascara);
            RaycastHit2D rHit2 = Physics2D.Raycast(transform.position - new Vector3(0.5f, 0, 0), Vector2.down, distanciaRaycast, mascara);
            if (rHit.collider != null || rHit2.collider != null)
            {
                Saltar(); 
            }
        }

        if(rb.velocity.y *-1 <= -keyVelocity)
        {
            activable = false;
        }
        else
        {
            Invoke("Desactiva", 0.1f);
        }
    }
    void Saltar()
    {
        rb.AddForce(Vector2.up * jumpForce);

    }
    void Desactiva()
    {
        activable = true;
    }
}
