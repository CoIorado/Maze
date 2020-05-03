using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakingKeys : MonoBehaviour
{
    private bool enter;
    public GameObject player;
    public GameObject obj;
    //public AudioClip sound;
    //private AudioSource source;
    //public GameObject tpKey;

    void Start ()
    {
        //source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter (Collider other)
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

    void Update ()
    {
        if ((Input.GetKeyUp(KeyCode.E) || Input.GetKeyDown(KeyCode.E)) && enter)
        {
            player.GetComponent<BringKey>().key = true;
           //source.PlayOneShot(sound);
           // transform.position = tpKey.transform.position;
           // obj.SetActive(false);
            Destroy(obj, 0.1f);
        }
    }
}
