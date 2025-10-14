using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Vector : MonoBehaviour {

    private Quaternion orig;
    public float angle = 1f;

    // Use this for initialization
    void Start () {
        orig = transform.rotation;
    }
	
	// Update is called once per frame
	void Update () {
        Quaternion rot = Quaternion.AngleAxis(angle, new Vector3(0f, 1f, 1f).normalized);
        transform.rotation = transform.rotation * rot;
    }
}
