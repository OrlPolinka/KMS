using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Trigger_Script : MonoBehaviour {

    public Light Point; // источник света

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

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
