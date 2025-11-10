using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.CompareTag("Ground")){
            AudioSource.PlayClipAtPoint(GetComponent<AudioSource>().clip, transform.position);
            Destroy(gameObject);
        }
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
