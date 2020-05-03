using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLantern : MonoBehaviour
{
    void Start()
    {
        GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.X))
        {
            GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
        }
    }
}
