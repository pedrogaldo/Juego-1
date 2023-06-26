using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiaColor : MonoBehaviour
{
    SpriteRenderer tamborPrendido;
    Color newColor;
    public Color m_newColor;
    private SpriteRenderer rend;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        // rend = GetComponent<SpriteRenderer>();
        // rend.Color = newColor;
       
        if (Input.GetKey(KeyCode.Q))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.green;
        }


        else if (Input.GetKey(KeyCode.W))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.green;
        }

        else if (Input.GetKey(KeyCode.E))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.green;
        }

        else if (Input.GetKey(KeyCode.R))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.green;
        }

        else if (Input.GetKey(KeyCode.T))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.green;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.green;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.green;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.green;
        }

        else if (Input.GetKey(KeyCode.F))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.green;
        }

        else if (Input.GetKey(KeyCode.G))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.green;
        }

        else if (Input.GetKey(KeyCode.Z))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.green;
        }

        else if (Input.GetKey(KeyCode.X))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.green;
        }

        else if (Input.GetKey(KeyCode.C))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.green;
        }

        else if (Input.GetKey(KeyCode.V))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.green;
        }

        else if (Input.GetKey(KeyCode.B))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.green;
        }

        else
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.red;        
        }
    } 
}
