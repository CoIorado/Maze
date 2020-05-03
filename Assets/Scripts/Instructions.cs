using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{
    public float updateTime = 5f;

    void Start()
    {
        
    }

   
    void Update()
    {
        updateTime -= Time.deltaTime;
        Debug.Log(updateTime);
    }

    void OnGUI()
    {
        if (updateTime >= 0)
        {
            GUI.color = Color.gray;
            GUI.skin.label.fontSize = 25;
            GUI.Label(new Rect(10, 10, 1000, 900), "WASD - ходить\nSpace - прыгать\nShift - бежать\nX - вкл/выкл фонарь\nE - вкл/выкл факел\nF - дверь/рычаг/ключ\nEsc - выход\n");
        }
    }
}
