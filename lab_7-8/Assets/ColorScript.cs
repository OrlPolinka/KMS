using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour {

    public Light Point1;
    public Light Point2;
    public Light Point3;
    public Transform Cylinder;

    public float maxIntensity = 5f;
    public float intensitySpeed = 0.1f;
    public float rotationSpeed = 50f;

    void OnTriggerStay(Collider col)
    {
        if (col.name == "player" || col.name == "robot")
        {
            if (Point1.intensity < maxIntensity)
                Point1.intensity += intensitySpeed * Time.deltaTime;

            if (Point2.intensity < maxIntensity)
                Point2.intensity += intensitySpeed * Time.deltaTime;

            if (Point3.intensity < maxIntensity)
                Point3.intensity += intensitySpeed * Time.deltaTime;

            if (Cylinder != null)
                Cylinder.Rotate(Vector3.back * rotationSpeed * Time.deltaTime, Space.World);
        }
    }

    void Start () {
		
	}
	
	void Update () {
		
	}
}
