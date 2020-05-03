using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public bool caught = false;
    public GameObject trap;
    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(trap);
            caught = true;
        }
    }
}
