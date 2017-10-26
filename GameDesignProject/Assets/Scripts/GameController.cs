using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public static bool gameOver;
	public static int gameOverState;
	public Text loseText;
	public Text winText;
	public Text restartText;

	// Use this for initialization
	void Start () {
		gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (ScoreScript.scoreValue >= 21) {
			gameOver = true;
			gameOverState = 0;
		}
		if (gameOver) {
			Time.timeScale = 0;
			switch (gameOverState) {
			case 0:
				winText.text = "GOOD BOY";
				break;
			case 1:
				loseText.text = "BAD BOY";
				break;
			}
			restartText.text = "Press 'return' to restart.";
			if (Input.GetKeyDown (KeyCode.Return)) {
				Application.LoadLevel (0);
				Time.timeScale = 1;
			}
		}
	}
}
