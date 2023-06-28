using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Platillo : MonoBehaviour
{

    SpriteRenderer tamborPresionado;
    Color newColor = new Color(0.3f, 0.4f, 0.6f, 0.3f);
    public Color m_newColor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            if (Input.GetKey(KeyCode.Space))
            {
                GetComponent<AudioSource>().enabled = true;
                tamborPresionado = GetComponent<SpriteRenderer>();
                tamborPresionado.color = new Color(tamborPresionado.color.r, tamborPresionado.color.g, tamborPresionado.color.b, 1f);

            }

            else
            {
                GetComponent<AudioSource>().enabled = false;
                tamborPresionado = GetComponent<SpriteRenderer>();
                tamborPresionado.color = new Color(tamborPresionado.color.r, tamborPresionado.color.g, tamborPresionado.color.b, 0.5f);
            }
       

    }
}
