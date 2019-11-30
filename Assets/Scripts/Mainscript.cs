using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainscript : MonoBehaviour
{

    private int turno = 0;
    private int vidas = 2;
    private Vector2 pos_inicial;

    // Start is called before the first frame update
    void Start()
    {
        pos_inicial = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void check_turn(int n_tecla){
        if(n_tecla == turno){
            turno ++;
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
