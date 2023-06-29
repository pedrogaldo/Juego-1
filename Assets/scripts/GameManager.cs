using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public SpriteRenderer[] tambores; //este es un array de sprites para prenderlos cuando se haga una seleccion random
    private int selectDrum;
    public float stayLit;
    private float stayLitCounter;




    public SpriteRenderer bombo;//estos sprites son para prender el tambor que corresponda cuando se presione una tecla
    public SpriteRenderer snare;
    public SpriteRenderer platillo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //controla bombo
        if (Input.GetKey(KeyCode.Q))
        {
            prenderBombo();
        }
        else if (Input.GetKey(KeyCode.W))
        {
            prenderBombo();
        }
        else if (Input.GetKey(KeyCode.E))
        {
            prenderBombo();
        }
        else if (Input.GetKey(KeyCode.R))
        {
            prenderBombo();
        }
        else if (Input.GetKey(KeyCode.T))
        {
            prenderBombo();
        }
        else if (Input.GetKey(KeyCode.A))
        {
            prenderBombo();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            prenderBombo();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            prenderBombo();
        }
        else if (Input.GetKey(KeyCode.F))
        {
            prenderBombo();
        }
        else if (Input.GetKey(KeyCode.G))
        {
            prenderBombo();
        }
        else if (Input.GetKey(KeyCode.Z))
        {
            prenderBombo();
        }
        else if (Input.GetKey(KeyCode.X))
        {
            prenderBombo();
        }
        else if (Input.GetKey(KeyCode.C))
        {
            prenderBombo();
        }
        else if (Input.GetKey(KeyCode.V))
        {
            prenderBombo();
        }
        else if (Input.GetKey(KeyCode.B))
        {
            prenderBombo();
        }else
        {
            bombo.GetComponent<AudioSource>().enabled = false;
            bombo.color = new Color(bombo.color.r, bombo.color.g, bombo.color.b, 0.5f);
        }



        //Controla Redo
        if (Input.GetKey(KeyCode.Y))
        {
            prenderSnare();
        }
        else if (Input.GetKey(KeyCode.U))
        {
            prenderSnare();
        }
        else if (Input.GetKey(KeyCode.I))
        {
            prenderSnare();
        }
        else if (Input.GetKey(KeyCode.O))
        {
            prenderSnare();
        }
        else if (Input.GetKey(KeyCode.P))
        {
            prenderSnare();
        }
        else if (Input.GetKey(KeyCode.H))
        {
            prenderSnare();
        }
        else if (Input.GetKey(KeyCode.J))
        {
            prenderSnare();
        }
        else if (Input.GetKey(KeyCode.K))
        {
            prenderSnare();
        }
        else if (Input.GetKey(KeyCode.L))
        {
            prenderSnare();
        }
        else if (Input.GetKey(KeyCode.N))
        {
            prenderSnare();
        }
        else if (Input.GetKey(KeyCode.M))
        {
            prenderSnare();
        }
        else if (Input.GetKey(KeyCode.Comma))
        {
            prenderSnare();
        }
        else if (Input.GetKey(KeyCode.Colon))
        {
            prenderSnare();
        }
        else if (Input.GetKey(KeyCode.Minus))
        {
            prenderSnare();
        }
        else if (Input.GetKey(KeyCode.Semicolon))
        {
            prenderSnare();
        }
        else
        {
            snare.GetComponent<AudioSource>().enabled = false;
            snare.color = new Color(snare.color.r, snare.color.g, snare.color.b, 0.5f);
        }


        //controla platillo

        if (Input.GetKey(KeyCode.Space))
        {
            prenderPlatillo();
        }else
        {
            platillo.GetComponent<AudioSource>().enabled = false;
            platillo.color = new Color(platillo.color.r, platillo.color.g, platillo.color.b, 0.5f);
        }


        if (stayLitCounter > 0)
        {
            stayLitCounter -= Time.deltaTime;
        }else
        {
            tambores[selectDrum].color = new Color(tambores[selectDrum].r, tambores[selectDrum].g, tambores[selectDrum].b, 0.5f);
        }

    }


    public void prenderBombo()
    {
        bombo.GetComponent<AudioSource>().enabled = true;
        bombo.color = new Color(bombo.color.r, bombo.color.g, bombo.color.b, 1f);
    }

    public void prenderSnare()
    {
        snare.GetComponent<AudioSource>().enabled = true;
        snare.color = new Color(snare.color.r, snare.color.g, snare.color.b, 1f);
    }

    public void prenderPlatillo()
    {
        platillo.GetComponent<AudioSource>().enabled = true;
        platillo.color = new Color(platillo.color.r, platillo.color.g, platillo.color.b, 1f);
    }

    public void startGame()
    {
        selectDrum = Random.Range(0, tambores.Length);
        tambores[selectDrum].color = new Color(tambores[selectDrum].r, tambores[selectDrum].g, tambores[selectDrum].b, 1f);
        stayLitCounter = stayLit;
    }
}

