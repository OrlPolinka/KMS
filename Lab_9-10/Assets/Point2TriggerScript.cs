using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point2TriggerScript : MonoBehaviour {

    public Light redLight;

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            redLight.intensity = 10f;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            redLight.intensity = 0f;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
