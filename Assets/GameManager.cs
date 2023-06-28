using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public SpriteRenderer[] tambores;
    private int selectDrum;

    public float stayLit;
    private float stayLitCounter;


   SpriteRenderer tamborPresionado;

   GameObject bombo = tambores.transform.GetChild(0).bombo;


    void Start()
    {   //Prende luces
        if (stayLitCounter > 0)
        {
            stayLitCounter -= Time.deltaTime;
        }else
        {
            tambores[selectDrum].color = new Color(tambores[selectDrum].color.r, tambores[selectDrum].color.g, tambores[selectDrum].color.b, 0.5f);
        }

        //controla bombo

        if (Input.GetKey(KeyCode.Q))
        {
            bombo<AudioSource>().enabled = true;
            tamborPresionado = bombo<SpriteRenderer>();
            tamborPresionado.color = new Color(tamborPresionado.color.r, tamborPresionado.color.g, tamborPresionado.color.b, 1f);
        }




        //controla redo

        //controla platillo

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void iniciarJuego()
    {

        selectDrum = Random.Range(0, tambores.Length);
        tambores[selectDrum].color = new Color(tambores[selectDrum].color.r, tambores[selectDrum].color.g, tambores[selectDrum].color.b, 1f);
        stayLitCounter = stayLit;

    }

}
