using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Activador : MonoBehaviour
{
    public int numero;
    public AudioClip nota;
    private AudioSource audiosource;
    void Start()
    {
        audiosource = GetComponent<AudioSource> ();
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
                GameObjectVariable.GetComponent<Mainscript>().check_turn(numero);
                Debug.Log("ACTIVO LA NOTA" + numero);
            }
        }
    }

    public void Playsound(int numero)
    {
       // source.PlayOneShot(clip);
        
    }
}
