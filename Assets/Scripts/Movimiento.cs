using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public static bool activable = false;
    public float speed;
    public float jumpForce;
    public float distanciaRaycast;
    public float keyVelocity;

    public LayerMask mascara;
    Rigidbody2D rb;

    float ejeX;
    float currentVelocity;

    float localSpeed;
    Vector3 mLastPosition; 

    bool miraDerecha;
    SpriteRenderer sprite;

    Animator animPersonaje;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentVelocity = 0;
        sprite = GetComponent<SpriteRenderer>();
        animPersonaje = GetComponent<Animator>();
    }

    void Update()
    {
        print((localSpeed));
        localSpeed = Mathf.Abs(transform.position.x - mLastPosition.x) / Time.deltaTime;
        mLastPosition = transform.position;
        animPersonaje.SetFloat("speed", localSpeed);

        ejeX = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3((ejeX * (Time.deltaTime * speed)) , 0, 0));

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (!miraDerecha)
            {
                sprite.flipX = true;
                miraDerecha = !miraDerecha;
            }
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (miraDerecha)
            {
                sprite.flipX = false;
                miraDerecha = !miraDerecha;
            }
        }
        
    }
    private void FixedUpdate()
    {
        //Debug.DrawLine((transform.position + new Vector3(0.5f, 0, 0)), transform.position + new Vector3(0.5f, -distanciaRaycast * transform.localScale.x, 0), Color.white, Mathf.Infinity);
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit2D rHit = Physics2D.Raycast(transform.position + new Vector3(0.5f,0,0), Vector2.down, distanciaRaycast * transform.localScale.x, mascara);
            RaycastHit2D rHit2 = Physics2D.Raycast(transform.position - new Vector3(0.5f, 0, 0), Vector2.down, distanciaRaycast * transform.localScale.x, mascara);
            if (rHit.collider != null || rHit2.collider != null)
            {
                if(rb.velocity.y == 0)
                {
                    Saltar();
                    animPersonaje.SetTrigger("Jump");
                }
               
            }
        }

        if(rb.velocity.y <= keyVelocity)
        {
            activable = true;
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
        activable = false;
    }
}
