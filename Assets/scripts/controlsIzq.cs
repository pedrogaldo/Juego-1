using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlsIzq : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        //tambor izquierdo

        if (Input.GetKey(KeyCode.Q))
        {
            GetComponent<Renderer>().enabled = false;
        }

        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Renderer>().enabled = false;
        }

        if (Input.GetKey(KeyCode.E))
        {
            GetComponent<Renderer>().enabled = false;
        }

        if (Input.GetKey(KeyCode.R))
        {
            GetComponent<Renderer>().enabled = false;
        }

        if (Input.GetKey(KeyCode.T))
        {
            GetComponent<Renderer>().enabled = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Renderer>().enabled = false;
        }

        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Renderer>().enabled = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Renderer>().enabled = false;
        }

        if (Input.GetKey(KeyCode.F))
        {
            GetComponent<Renderer>().enabled = false;
        }

        if (Input.GetKey(KeyCode.G))
        {
            GetComponent<Renderer>().enabled = false;
        }

        if (Input.GetKey(KeyCode.Z))
        {
            GetComponent<Renderer>().enabled = false;
        }

        if (Input.GetKey(KeyCode.X))
        {
            GetComponent<Renderer>().enabled = false;
        }

        if (Input.GetKey(KeyCode.C))
        {
            GetComponent<Renderer>().enabled = false;
        }

        if (Input.GetKey(KeyCode.V))
        {
            GetComponent<Renderer>().enabled = false;
        }

        if (Input.GetKey(KeyCode.B))
        {
            GetComponent<Renderer>().enabled = false;
        }





        //Tambor derecho

        if (Input.GetKey(KeyCode.Y))
        {
            GetComponent<Renderer>().enabled = true;
        }

        if (Input.GetKey(KeyCode.U))
        {
            GetComponent<Renderer>().enabled = true;
        }

        if (Input.GetKey(KeyCode.I))
        {
            GetComponent<Renderer>().enabled = true;
        }

        if (Input.GetKey(KeyCode.O))
        {
            GetComponent<Renderer>().enabled = true;
        }

        if (Input.GetKey(KeyCode.P))
        {
            GetComponent<Renderer>().enabled = true;
        }

        if (Input.GetKey(KeyCode.H))
        {
            GetComponent<Renderer>().enabled = true;
        }

        if (Input.GetKey(KeyCode.J))
        {
            GetComponent<Renderer>().enabled = true;
        }

        if (Input.GetKey(KeyCode.K))
        {
            GetComponent<Renderer>().enabled = true;
        }

        if (Input.GetKey(KeyCode.L))
        {
            GetComponent<Renderer>().enabled = true;
        }

        if (Input.GetKey(KeyCode.N))
        {
            GetComponent<Renderer>().enabled = true;
        }

        if (Input.GetKey(KeyCode.M))
        {
            GetComponent<Renderer>().enabled = true;
        }

        if (Input.GetKey(KeyCode.Comma))
        {
            GetComponent<Renderer>().enabled = true;
        }

        if (Input.GetKey(KeyCode.Colon))
        {
            GetComponent<Renderer>().enabled = true;
        }

        // if (Input.GetKey(KeyCode.Hypher))
        // {
        //      GetComponent<Renderer>().enabled = false;
        //  }

        //  if (Input.GetKey(KeyCode.))
        //   {
        //       GetComponent<Renderer>().enabled = false;
        //   }



    }
}
