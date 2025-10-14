using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2_lab7_8 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float hor = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        transform.Translate(hor, 0, vert);

        float horMouse = Input.GetAxis("Mouse X");
        transform.Rotate(0, horMouse, 0);
    }
}
