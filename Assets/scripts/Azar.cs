using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Azar : MonoBehaviour
{


    public SpriteRenderer[] tambores;
    private int selectDrum;

    public float stayLit;
    private float stayLitCounter;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (stayLitCounter > 0)
        {
            stayLitCounter -= Time.deltaTime;
        }
        else
        {
            tambores[selectDrum].color = new Color(tambores[selectDrum].color.r, tambores[selectDrum].color.g, tambores[selectDrum].color.b, 0.5f);
        }
    }


    public void iniciarJuego()
    {

        selectDrum = Random.Range(0, tambores.Length);
        tambores[selectDrum].color = new Color(tambores[selectDrum].color.r, tambores[selectDrum].color.g, tambores[selectDrum].color.b, 1f);
        stayLitCounter = stayLit;

    }


}
