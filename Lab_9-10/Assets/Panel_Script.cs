using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_Script : MonoBehaviour
{
    public Tank_script tank;              
    public core_generated core;           

    private float h = 0;                  

    void OnGUI()
    {
        if (tank == null || core == null) return;

        if (h == 0)
        {
            GUI.BeginGroup(new Rect(10, h, 250, 300));
            GUI.Box(new Rect(10, 0, 230, 200), "УПРАВЛЕНИЕ СКОРОСТЬЮ");

            GUI.Label(new Rect(15, 30, 200, 30), "Скорость танка: " + tank.moveSpeed.ToString("F1"));
            tank.moveSpeed = GUI.HorizontalSlider(new Rect(15, 50, 170, 30), tank.moveSpeed, 0.0f, 10.0f);

            GUI.Label(new Rect(15, 90, 200, 30), "Скорость снаряда: " + core.coreSpeed.ToString("F1"));
            core.coreSpeed = GUI.HorizontalSlider(new Rect(15, 110, 170, 30), core.coreSpeed, 0.0f, 30.0f);

            if (GUI.Button(new Rect(10, 150, 90, 25), "Скрыть ПУ")) { Hide(); }

            GUI.EndGroup();
        }
        else
        {
            if (GUI.Button(new Rect(10, 10, 100, 25), "Показать ПУ")) { Show(); }
        }
    }


    public void Hide() { h = -200; }
    public void Show() { h = 0; }
}
