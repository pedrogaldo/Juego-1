using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class encenderLuz : MonoBehaviour
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
            GetComponent<Color>();
        }

        else if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.E))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.R))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.T))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.F))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.G))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.Z))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.X))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.C))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.V))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.B))
        {
            GetComponent<Light>().enabled = true;
        }

        else
        {
            GetComponent<Light>().enabled = false;
        }
    }
}
