using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Euler : MonoBehaviour {

    private Vector3 currentEuler;

    // Use this for initialization
    void Start () {
        currentEuler = transform.eulerAngles;
    }
	
	// Update is called once per frame
	void Update () {
        currentEuler.z += 1f;
        currentEuler.x += 1f;
        transform.eulerAngles = currentEuler;
    }
}
