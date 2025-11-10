using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point1TriggerScript : MonoBehaviour {

	public Light blueLight;

	void OnTriggerEnter(Collider col)
	{
		if (col.CompareTag("Player"))
		{
			blueLight.intensity = 10f;
		}
	}

	void OnTriggerExit(Collider col)
	{
        if (col.CompareTag("Player"))
        {
            blueLight.intensity = 0f;
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
