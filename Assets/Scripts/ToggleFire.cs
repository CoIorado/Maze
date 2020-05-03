using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleFire : MonoBehaviour
{
    public GameObject fire;
    private bool isIn;
    private bool isFire = true;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isIn = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isIn = false;
        }
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            if (isIn == true)
            {
                GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
                isFire = !isFire;
                fire.SetActive(isFire);
            }
        }
    }
}
