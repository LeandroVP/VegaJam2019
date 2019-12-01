using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Activador : MonoBehaviour
{
    public int numero;
    public AudioClip nota;
    public GameObject sManager;
    private AudioSource audiosource;
    public GameObject main;
    public Animator animColision;
    public bool animandose = false;
    public SpriteRenderer srBrillo;
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        Invoke("Wait", 0.1f);
        animColision = GetComponent<Animator>();
        srBrillo = transform.GetChild(0).GetComponent<SpriteRenderer>();
        srBrillo.color = new Color(0, 0, 0, 0);

    }

    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player")&& animandose == false)
        {
            animandose = true;
            animColision.SetBool("Pisando", true);
            audiosource.Play();
            if(Movimiento.activable == true)
            {
                main.GetComponent<Mainscript>().check_turn(numero);
                animColision.SetBool("Activa", true);
                StartCoroutine(Enciende());
               // Invoke("RetrasaSonido", 0.5f);
            }
        }
    }
    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            animColision.SetBool("Pisando", false);
        }
            
    }
    void Wait()
    {
        nota = sManager.GetComponent<SoundManager>().sonidos[numero];
        audiosource.clip = nota;
    } 
    void RetrasaSonido()
    {
        //audiosource.Play();
    }
    void SeñalFalse()
    {
        animandose = false;
    }
    IEnumerator Enciende()
    {
        for(int i = 0; i<50; i++)
        {
            srBrillo.color = new Color(119, 148, 159, 0 + i / 100f);
            yield return null;
        }
        //srBrillo.color = new Color(119, 148, 159, 1);
    }
}
