using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Script2_lab6 : MonoBehaviour, IPointerClickHandler
{

    public void OnPointerClick(PointerEventData eventData)
    {
        float red = Random.Range(.0f, 1.0f);
        float green = Random.Range(.0f, 1.0f);
        float blue = Random.Range(.0f, 1.0f);
        Color col1 = new Color(red, green, blue);
        GetComponent<Renderer>().material.color = col1;

        int f = 400;
        Vector3 t = eventData.pointerPressRaycast.worldPosition;
        Vector3 c = Camera.main.transform.position;
        Vector3 d = t - c;
        d = d.normalized;
        gameObject.GetComponent<Rigidbody>().AddForceAtPosition(d * f, t);
    }
}
