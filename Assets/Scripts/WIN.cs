using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WIN : MonoBehaviour {

    public GameObject player;
    private bool isIn;

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("Main");
        }
    }

    
}
