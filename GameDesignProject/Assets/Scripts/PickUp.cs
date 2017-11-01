using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour {

    public GameObject currentObj;
    bool isHolding;
    public GameObject holder;
    public Text pressQ;

	// Use this for initialization
	void Start () {
        isHolding = false;

    }
	
	// Update is called once per frame
	void FixedUpdate () {

        // Pick up objects
        if (Input.GetKeyDown("q") && currentObj && !isHolding)
        {
            resetQ();
            isHolding = true;
            currentObj.transform.position = holder.transform.position;
            currentObj.transform.parent = holder.transform;
        }

        // Drop objects
        else if (Input.GetKeyDown("q") && isHolding)
        {
            isHolding = false;
            currentObj.GetComponent<Rigidbody>().useGravity = true;
            currentObj.GetComponent<Rigidbody>().isKinematic = false;
            currentObj.transform.parent = null;
            currentObj = null;
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        // Check if it is not carrying an object
        if (other.CompareTag("Object") && !currentObj && !isHolding){
            setPressQ();
            currentObj = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Object"))
        {
            if (other.gameObject == currentObj && !isHolding)
            {
                resetQ();
                currentObj = null;
            }
        }
    }

    void setPressQ()
    {
        pressQ.text = "Press Q to pick up.";
    }

    void resetQ()
    {
        pressQ.text = "";
    }
}
