using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1_lab7_8 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public GameObject cube1;
	public GameObject cube2;

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.name == "Capsule")
		{
			Color capsuleColor = col.gameObject.GetComponent<Renderer>().material.color;

			if(cube1 != null) 
				cube1.GetComponent<Renderer>().material.color = capsuleColor;

            if (cube2 != null)
                cube2.GetComponent<Renderer>().material.color = capsuleColor;
        }
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
