using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeDark : MonoBehaviour
{
    SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = new Color(0, 0, 0, 1);
        StartCoroutine(Desvanece());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator Desvanece()
    {
        for(int i = 0; i<100; i++)
        {
            sprite.color = new Color(0, 0, 0, 1 - i/100f);
            yield return null;
        }
    }

    public IEnumerator Oscurece()
    {
        for (int i = 0; i < 100; i++)
        {
            sprite.color = new Color(0, 0, 0, 0 + i / 100f);
            yield return null;
        }
        sprite.color = new Color(0, 0, 0, 1);
    }
}
