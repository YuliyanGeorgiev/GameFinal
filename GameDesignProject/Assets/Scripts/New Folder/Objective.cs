using UnityEngine;
using System.Collections;

namespace SpawnPoop
{
    public class Objective : MonoBehaviour
    {
        public GameObject ObjectiveSign_01;
        public GameObject ThirdPersonController;
        private SpawnPoop poopCountScript;
        private int PoopCount;

        void OnTriggerStay(Collider other)
        {
            poopCountScript = ThirdPersonController.GetComponent<SpawnPoop>();
            PoopCount = poopCountScript.poopCount;

            if (other.gameObject.name == "Objective_01" && (Input.GetKeyDown("r")) && PoopCount != 0)
            {
                ObjectiveSign_01.SetActive(false);
            }
        }
    }
}