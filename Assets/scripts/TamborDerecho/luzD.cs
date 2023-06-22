using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luzD : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        //Tambor derecho

        if (Input.GetKey(KeyCode.Y))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.U))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.I))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.O))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.P))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.H))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.J))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.K))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.L))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.N))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.M))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.Comma))
        {
            GetComponent<Light>().enabled = true;
        }

        else if (Input.GetKey(KeyCode.Colon))
        {
            GetComponent<Light>().enabled = true;
        }

        // if (Input.GetKey(KeyCode.Hypher))
        // {
        //            GetComponent<Light>().enabled = true;
        //  }

        //  if (Input.GetKey(KeyCode.))
        //   {
        //             GetComponent<Light>().enabled = true;
        //   }

        else
        {
            GetComponent<Light>().enabled = false;
        }

    }
}
