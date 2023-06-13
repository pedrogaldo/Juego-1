using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour {

	// Use this for initialization
	void Start () {


    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Renderer>().enabled = true;
        }



        if (Input.GetKey(KeyCode.X))
        {
            GetComponent<Renderer>().enabled = false;
        }



    }
}
