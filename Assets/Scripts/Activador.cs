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
    void Start()
    {
        audiosource = GetComponent<AudioSource> ();
        nota = sManager.GetComponent<SoundManager>().sonidos[numero];
        audiosource.clip = nota;      
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("REPRODUZCO LA NOTA" + numero);
            audiosource.Play();
            if(Movimiento.activable == true)
            {
                main.GetComponent<Mainscript>().check_turn(numero);

                Debug.Log("ACTIVO LA NOTA" + numero);
            }
        }
    }
        
}
