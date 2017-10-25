using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodSpawner : MonoBehaviour {

    public GameObject food;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Object"))
        {
            Destroy(other.gameObject);
            Instantiate( food, transform.position, transform.rotation);
            // Play good boy sound here
        }

        if (other.CompareTag("Food"))
        {
            // Food kept falling through the ground so I had to improvise
            other.GetComponent<Rigidbody>().isKinematic = true;
            other.GetComponent<Rigidbody>().useGravity = false;
        }
    }
}
