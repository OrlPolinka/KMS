using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateTriggerScript : MonoBehaviour {

    public Transform GateLeft;
    public Transform GateRight;
    public Transform FlyingBar;

    public Vector3 leftOpenOffset = new Vector3(-1f, 0, 0);
    public Vector3 rightOpenOffset = new Vector3(1f, 0, 0);

    private Vector3 leftClosedPos;
    private Vector3 rightClosedPos;

    private bool isOpening = false;
    private bool isFlying = false;

    public float flySpeed = 1f;
    public float rotationSpeed = 100f;

    void Start () {
        leftClosedPos = GateLeft.position;
        rightClosedPos = GateRight.position;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "player")
        {
            isOpening = true;
        }

        if (col.name == "robot")
        {
            isFlying = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.name == "player")
        {
            isOpening = false;
        }

        if (col.name == "robot")
        {
            isFlying = false;
        }
    }

    void Update () {
        if (isOpening)
        {
            GateLeft.position = Vector3.Lerp(GateLeft.position, leftClosedPos + leftOpenOffset, Time.deltaTime * 2);
            GateRight.position = Vector3.Lerp(GateRight.position, rightClosedPos + rightOpenOffset, Time.deltaTime * 2);
        }
        else
        {
            GateLeft.position = Vector3.Lerp(GateLeft.position, leftClosedPos, Time.deltaTime * 2);
            GateRight.position = Vector3.Lerp(GateRight.position, rightClosedPos, Time.deltaTime * 2);
        }

        if (isFlying && FlyingBar != null)
        {
            FlyingBar.Rotate(Vector3.left * rotationSpeed * Time.deltaTime, Space.World);
            FlyingBar.Translate(Vector3.back * flySpeed * Time.deltaTime, Space.World);
        }
    }
}
