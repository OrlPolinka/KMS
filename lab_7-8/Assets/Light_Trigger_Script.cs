using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Trigger_Script : MonoBehaviour {

    public Light Point; 

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "player" && Point != null)
        {
            Point.enabled = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.name == "player" && Point != null)
        {
            Point.enabled = false;
        }
    }

    void Start () {
		
	}
	
	void Update () {
		
	}
}
