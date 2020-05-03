using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainteleports : MonoBehaviour
{
    public GameObject tpKey;
    public GameObject tpDoor;
    public GameObject tpStart;
    public GameObject tpEnd;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Keypad2))
        {
            transform.position = tpKey.transform.position;
        }

        if (Input.GetKeyUp(KeyCode.Keypad3))
        {
            transform.position = tpDoor.transform.position;
        }

        if (Input.GetKeyUp(KeyCode.Keypad1))
        {
            transform.position = tpStart.transform.position;
        }

        if (Input.GetKeyUp(KeyCode.Keypad4))
        {
            transform.position = tpEnd.transform.position;
        }
    }
}
