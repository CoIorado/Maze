using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSound : MonoBehaviour
{
    private AudioSource source;
    public AudioClip sound;

    void Start ()
    {
        source = GetComponent<AudioSource>();
    }

    void OnTriggerExit (Collider other)
    {
        if (other.tag == "Player")
        {
            source.PlayOneShot(sound);
            Destroy(this, 1f);
        }
    }
}
