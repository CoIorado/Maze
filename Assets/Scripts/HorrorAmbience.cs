using UnityEngine;

public class HorrorAmbience : MonoBehaviour
{
    public AudioClip horrorSound;
    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        source.PlayOneShot(horrorSound);
    }
}
