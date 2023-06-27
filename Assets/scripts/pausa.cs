using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class pausa : MonoBehaviour
{

    public static bool pausado = false;
    public GameObject menuPausa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame



    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            if (pausado)
            {
                Resumir();
            }

            else
            {
                Pausar();
            }
        }


    }

    void Resumir()
    {
        menuPausa.SetActive(false);
        Time.timeScale = 1f;
        pausado = false;
    }


    void Pausar()
    {
        menuPausa.SetActive(true);
        Time.timeScale = 0f;
        pausado = true;
    }


}
