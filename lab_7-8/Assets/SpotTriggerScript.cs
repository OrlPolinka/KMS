using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotTriggerScript : MonoBehaviour {

    public GameObject SpotLight; 
    public float rotationSpeed = 50f;

    void OnTriggerStay(Collider col)
    {
        if (col.name == "player" && SpotLight != null)
        {
            SpotLight.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
    }

    void Start () {
		
	}
	
	void Update () {
		
	}
}
