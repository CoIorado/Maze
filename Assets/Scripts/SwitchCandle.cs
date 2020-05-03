using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCandle : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.X))
        {
            GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
        }
    }
}
