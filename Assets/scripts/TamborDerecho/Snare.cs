using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snare : MonoBehaviour
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
        if (Input.GetKey(KeyCode.Y))
        {
            GetComponent<AudioSource>().enabled = true;
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.U))
        {
            GetComponent<AudioSource>().enabled = true;
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.I))
        {
            GetComponent<AudioSource>().enabled = true;
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.O))
        {
            GetComponent<AudioSource>().enabled = true;
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.P))
        {
            GetComponent<AudioSource>().enabled = true;
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.H))
        {
            GetComponent<AudioSource>().enabled = true;
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.J))
        {
            GetComponent<AudioSource>().enabled = true;
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.K))
        {
            GetComponent<AudioSource>().enabled = true;
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.L))
        {
            GetComponent<AudioSource>().enabled = true;
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.N))
        {
            GetComponent<AudioSource>().enabled = true;
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.M))
        {
            GetComponent<AudioSource>().enabled = true;
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.Comma))
        {
            GetComponent<AudioSource>().enabled = true;
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        else if (Input.GetKey(KeyCode.Colon))
        {
            GetComponent<AudioSource>().enabled = true;
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.yellow;
        }

        // if (Input.GetKey(KeyCode.Hypher))
        // {
        //    GetComponent<AudioSource>().enabled = true;

        //  }

        //  if (Input.GetKey(KeyCode.))
        //   {
        //     GetComponent<AudioSource>().enabled = true;

        //   }

        else
        {
            GetComponent<AudioSource>().enabled = false;
            tamborPrendido = GetComponent<SpriteRenderer>();
            tamborPrendido.color = Color.grey;

        }
    }
}
