using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombo : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            GetComponent<AudioSource>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.W))
        {
            GetComponent<AudioSource>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.E))
        {
            GetComponent<AudioSource>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.R))
        {
            GetComponent<AudioSource>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.T))
        {
            GetComponent<AudioSource>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            GetComponent<AudioSource>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            GetComponent<AudioSource>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            GetComponent<AudioSource>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.F))
        {
            GetComponent<AudioSource>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.G))
        {
            GetComponent<AudioSource>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.Z))
        {
            GetComponent<AudioSource>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.X))
        {
            GetComponent<AudioSource>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.C))
        {
            GetComponent<AudioSource>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.V))
        {
            GetComponent<AudioSource>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.B))
        {
            GetComponent<AudioSource>().enabled = true;
        }

        else
        {
            GetComponent<AudioSource>().enabled = false;
        }
    }
}
