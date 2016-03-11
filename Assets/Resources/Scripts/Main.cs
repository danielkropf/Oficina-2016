using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	public static bool clickedAnArmy;
	public static GameObject armyClicked;
	public static int playerTurn = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void endTurn() {
		if (playerTurn == 1)
			playerTurn = 2;
		if (playerTurn == 2)
			playerTurn = 2;
	}
}
