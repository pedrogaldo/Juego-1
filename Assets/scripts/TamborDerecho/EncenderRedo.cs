using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncenderRedo : MonoBehaviour
{
    SpriteRenderer tamborPrendido;
    Color newColor;
    public Color m_newColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //tambor izquierdo

        if (Input.GetKey(KeyCode.Y))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }


        else if (Input.GetKey(KeyCode.U))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.I))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.O))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.P))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.H))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.J))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.K))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.L))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.B))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.N))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.M))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.Comma))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.Colon))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.B))
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else
        {
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.grey;
        }
    }
}