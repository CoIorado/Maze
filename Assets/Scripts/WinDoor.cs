using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinDoor : MonoBehaviour
{
    public GameObject player;
    public float smooth = 5f;
    public float updateTime = 2f;
    private Vector3 openRot;
    private Vector3 defaultRot;
    private bool isIn;
    private bool open;
    private bool isGUI;

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
            updateTime = 0;
        }
    }

    void Start()
    {
        openRot = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 90, transform.eulerAngles.z);
        defaultRot = transform.eulerAngles;
    }

    void Update()
    {
        if (isIn == true && Input.GetKeyDown(KeyCode.F))
        {
            if (player.GetComponent<BringKey>().key == true)
            {
                open = !open;
            }
            else
            {
                isGUI = true;
                updateTime = 2f;
            }
        }

        if (isGUI)
        {
            updateTime -= Time.deltaTime;
        }

        if (open)
        {
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRot, smooth * Time.deltaTime);
        }
        else
        {
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, defaultRot, smooth * Time.deltaTime);
        }

        if (updateTime <= 0)
        {
            isGUI = false;
        }

        //Debug.Log(updateTime);
    }

    void OnGUI()
    {
        if (isGUI && isIn)
        {
            GUI.color = Color.red;
            GUI.skin.label.fontSize = 20;
            GUI.Label(new Rect(10, 10, 1000, 90), "Дверь заперта! Нужен ключ!");
        }
    }
}
