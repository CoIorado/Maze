using UnityEngine;

public class DieZone : MonoBehaviour
{
    public GameObject respawn;
    public GameObject gate;
    public GameObject toGate;
    private bool isCaught = false;

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = respawn.transform.position;
            isCaught = true;
        }
    }

    void Update ()
    {
        if (isCaught == true)
        {
            gate.transform.position = Vector3.MoveTowards(gate.transform.position, toGate.transform.position, Time.deltaTime);
        }
    }
}
