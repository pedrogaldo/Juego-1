using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausa : MonoBehaviour
{
    public static bool pausado = false;
    public GameObject menuPausa;
    // Update is called once per frame
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausado)
            {
                continuar();
            }

            else
            {
                pausar();
            }
        }    
    }

    public void continuar()
    {
        menuPausa.SetActive(false);
        Time.timeScale = 1f;
        pausado = false;
    }

    void pausar()
    {
        menuPausa.SetActive(true);
        Time.timeScale = 0f;
        pausado = true;
    }

}
