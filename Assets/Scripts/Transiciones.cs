using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transiciones : MonoBehaviour
{
    private Animator _transicionAnim;
    public GameObject fader;
    // Start is called before the first frame update
    void Start()
    {
        _transicionAnim = GetComponent<Animator>();
        
    }

    public void LoadScene(string scene)
    {
        fader.GetComponent<FadeDark>().Oscurecer();
        StartCoroutine(Transiciona(scene));
    }

    IEnumerator Transiciona(string scene){
        
        yield return new WaitForSeconds(1.75f);
        SceneManager.LoadScene(scene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
