using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBarTriggerScript : MonoBehaviour {

    public Transform FlyingBar;
    public float rotationSpeed = 100f;
    public float flySpeed = 1f;
    private bool isRotating = false;

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "robot")
        {
            isRotating = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.name == "robot")
        {
            isRotating = false;
        }
    }

    void Start () {
		
	}
	
	void Update () {
        if (isRotating && FlyingBar != null)
        {
            FlyingBar.Rotate(Vector3.left * rotationSpeed * Time.deltaTime, Space.World);
            FlyingBar.Translate(Vector3.back * flySpeed * Time.deltaTime, Space.World);
        }
    }
}
