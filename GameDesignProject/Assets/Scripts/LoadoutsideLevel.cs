using UnityEngine;

public class LoadoutsideLevel : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "NextLevel")
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                Application.LoadLevel("outsideLevel");
            }
        }
    }
}
