using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2_Script : MonoBehaviour {

    public float moveSpeed = 5f;
    public float rotateSpeed = 100f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.T)) // вперёд
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Y)) // назад
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.E)) // влево
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.R)) // вправо
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        float horMouse = Input.GetAxis("Mouse X");
        transform.Rotate(0, horMouse, 0);
    }
}
