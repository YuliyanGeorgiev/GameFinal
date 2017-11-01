using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor : MonoBehaviour {

    public Text openDoor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            openDoor.text = "Move the curosr on the door and press F";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        openDoor.text = "";
    }
}
