﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainscript : MonoBehaviour
{   
    private int turno = 0;
    public int vidas = 1;
    private Vector2 pos_inicial;
    private int teclas_totales;
    public GameObject Nteclas;
    public GameObject Player;
    public GameObject Win;
    private Vector2 distancia_win;
    public GameObject canvas;
    public Animator animPuerta;
    private bool won = false;
    public string mapaN;
    public string animName;
    public GameObject fader;

    // Start is called before the first frame update
    void Start()
    {
        pos_inicial = GameObject.FindGameObjectWithTag("Player").transform.position;
        teclas_totales=Nteclas.GetComponent<TeclasManager>().listaTeclas.Length;
    }

    // Update is called once per frame
    void Update()
    {
        distancia_win = Player.transform.position - Win.transform.position;

        if(distancia_win.magnitude < 1f)
        {
            print("Activo");
            fader.GetComponent<FadeDark>().Oscurecer();
            Invoke("Retrasar", 1.5f);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(canvas.activeSelf)
                canvas.SetActive(false);

            else 
                canvas.SetActive(true);
        }

    }

    public void check_turn(int n_tecla){
        if(!won){
        if(n_tecla == turno){
            turno ++;
            if (turno == teclas_totales)
            {
                animPuerta.SetTrigger(animName);
                won=true;
                
            }
        }
        else {
            vidas--;
        
            if (vidas != 0){

                GameObject.FindGameObjectWithTag("Player").transform.position=pos_inicial;
                turno=0;
        
            }
            else
            {
                //Funcion para reiniciar la escena
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        
    }
    }
    void Retrasar()
    {
        SceneManager.LoadScene(mapaN);
    }

}
