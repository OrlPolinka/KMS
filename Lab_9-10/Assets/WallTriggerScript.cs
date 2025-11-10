using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTriggerScript : MonoBehaviour {

	public Transform wall;
	public float rotateSpeed = 30f;

	void OnTriggerStay(Collider coll)
	{
		if (coll.CompareTag("Player"))
		{
			wall.Rotate(0, rotateSpeed * Time.deltaTime, 0);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
