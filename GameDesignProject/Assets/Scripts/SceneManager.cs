using UnityEngine;

public class SceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetKey("n"))
            {
                Application.LoadLevel("LivingRoom_01");
            }
        }
    
}
