using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class core_generated : MonoBehaviour {

	public float coreSpeed = 1.0f;
	public GameObject exp1;

	// Use this for initialization
	void Start () {
		Destroy(gameObject, 5);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.TransformDirection(Vector3.back * coreSpeed);
	}

	private void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "goal")
		{
			Instantiate(exp1, gameObject.transform);
            gameObject.GetComponent<AudioSource>().PlayOneShot(gameObject.GetComponent<AudioSource>().clip);
            GetComponent<Renderer>().enabled = false;
        }
	}
}
