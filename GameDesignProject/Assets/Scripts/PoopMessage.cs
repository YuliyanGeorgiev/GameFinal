using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PoopMessage : MonoBehaviour {

    public Text poopByR;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            poopByR.text = "Press R to poop.";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        poopByR.text = "";
        Destroy(gameObject);
    }
}
