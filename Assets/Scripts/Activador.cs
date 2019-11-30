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
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        Invoke("Wait", 0.1f);
        animColision = GetComponent<Animator>();
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            animColision.SetBool("Pisando", true);
            audiosource.Play();
            if(Movimiento.activable == true)
            {
                main.GetComponent<Mainscript>().check_turn(numero);

                Debug.Log("ACTIVO LA NOTA" + numero);
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
}
