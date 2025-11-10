using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1_lab7_8 : MonoBehaviour {

    public GameObject Cube1;

    public Texture Texture1; 
    public Texture Texture2; 

    void Start () {
        //GetComponent<Renderer>().material.color = Color.red;
    }

	

    void OnCollisionEnter(Collision col)
    {
        if (Texture1 != null)
        {
            col.gameObject.GetComponent<Renderer>().material.mainTexture = Texture1;
        }

        //Color myColor = GetComponent<Renderer>().material.color;
        //col.gameObject.GetComponent<Renderer>().material.color = myColor;
    }


    void Update () {
		float hor = Input.GetAxis("Horizontal");
		float vert = Input.GetAxis("Vertical");
		transform.Translate(hor, 0, vert);

		float horMouse = Input.GetAxis("Mouse X");
		transform.Rotate(0, horMouse, 0);

        if (Input.GetKeyDown(KeyCode.T))
        {
            if (Cube1 != null && Texture2 != null)
            {
                Cube1.GetComponent<Renderer>().material.mainTexture = Texture2;
            }
        }
    }
}
