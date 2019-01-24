using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{

    public bool enableKillBox = true;
    void OnTriggerEnter(Collider other)
    {
        if (enableKillBox)
        {
            if (other.tag == "Player")
            {
                other.GetComponent<PlayerController>().GotHit();
            }
        }
    }
}
