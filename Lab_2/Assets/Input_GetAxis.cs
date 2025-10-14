using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_GetAxis : MonoBehaviour {

    private float y_angle = 0f;
    private float x_angle = 0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
		transform.Translate(x, 0, z);

		float a = Input.GetAxis("Mouse Y");
		float b = Input.GetAxis("Mouse X");

		y_angle -= a;
		x_angle += b;

		y_angle = Mathf.Clamp(y_angle, 0f, 90f);

        transform.localRotation = Quaternion.Euler(y_angle, x_angle, 0f);
    }
}
