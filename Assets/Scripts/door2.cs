using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door2 : MonoBehaviour
{
    public float smooth = 5;
    public float openAngle = -90;
    private AudioSource source;
    public AudioClip openSound;
    private bool enter;
    private bool open;
    private Vector3 defaultRot;
    private Vector3 openRot;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enter = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enter = false;
        }
    }

    void Start()
    {
        source = GetComponent<AudioSource>();
        defaultRot = transform.eulerAngles;
        openRot = new Vector3(defaultRot.x, defaultRot.y + openAngle, defaultRot.z);
    }

    void Update()
    {
        if (open)
        {
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRot, smooth * Time.deltaTime);

        }
        else
        {
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, defaultRot, smooth * Time.deltaTime);
        }

        if (Input.GetKeyUp(KeyCode.F) && enter)
        {
            open = !open;
            source.PlayOneShot(openSound);
        }
    }
}
