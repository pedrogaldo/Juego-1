using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Azar : MonoBehaviour
{


    public GameObject[] tambores;
    private int selectDrum;
    public float stayLit;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void iniciarJuego()
    {
        selectDrum = Random.Range(0, tambores.Length);

        tambores[selectDrum].color = new Color(tambores[selectDrum].color.r, tambores[selectDrum].color.g, tambores[selectDrum].color.b, 1f);

    }
}
