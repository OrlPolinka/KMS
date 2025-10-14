using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Quaternion : MonoBehaviour {

	private Quaternion orig;
	public float angle = 1;

	// Use this for initialization
	void Start () {
		orig = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion rotX = Quaternion.AngleAxis(angle, Vector3.right);
		Quaternion rotZ = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = transform.rotation * rotX * rotZ;
	}
}
