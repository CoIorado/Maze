using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretDoor : MonoBehaviour
{
    public GameObject lever;
    public GameObject toLever;
    public GameObject secretDoor;
    public GameObject toDoor;
    private Vector3 defaultRot;
    private Vector3 openRot;
    private Vector3 defaultDoor;
    private Vector3 openDoor;
    private bool isIn = false;
    private bool open;

    public float smooth = 10f;
    public float speed = 5f;

    void Start ()
    {
        defaultRot = lever.transform.eulerAngles;
        openRot = toLever.transform.eulerAngles;
        openDoor = toDoor.transform.position;
        defaultDoor = secretDoor.transform.position;
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            isIn = true;
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.tag == "Player")
        {
            isIn = false;
        }
    }

    void Update ()
    {
        if (Input.GetKeyUp(KeyCode.F) && isIn)
        {
            open = !open;
        }

        if (open)
        {
            lever.transform.eulerAngles = Vector3.Slerp(lever.transform.eulerAngles, openRot, smooth * Time.deltaTime);
            secretDoor.transform.position = Vector3.MoveTowards(secretDoor.transform.position, openDoor, speed * Time.deltaTime);
            //secretDoor.GetComponent<Renderer>().material.color = Color.black;
        }
        else
        {
            lever.transform.eulerAngles = Vector3.Slerp(lever.transform.eulerAngles, defaultRot, smooth * Time.deltaTime);
            secretDoor.transform.position = Vector3.MoveTowards(secretDoor.transform.position, defaultDoor, speed * Time.deltaTime);
        }
    }
}
