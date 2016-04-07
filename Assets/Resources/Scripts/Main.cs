using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Main : MonoBehaviour {

	public static bool clickedAnArmy;
	public static GameObject armyClicked;
	public static int playerTurn = 1;
	public static GameObject[] gos;
	public GameObject[] buttonsToInvokeUnits;
	public GameObject turn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gos = GameObject.FindGameObjectsWithTag("Unit");
		Debug.Log("gos: " + gos);
	}

	public void endTurn() {
		if (playerTurn == 1) playerTurn = 2;
		else if (playerTurn == 2) playerTurn = 1;

		for (int i = 0; i < gos.Length; i++)
		{
			gos[i].GetComponent<Movement2>().action = true;
			gos[i].GetComponent<Movement2>().ChangeColor(true);
		}
		for (int i = 0; i < buttonsToInvokeUnits.Length; i++) buttonsToInvokeUnits[i].GetComponent<NormalUnit>().invokedThisTurn = false;
		turn.GetComponent<Text>().text = "Turno: Player " + playerTurn;
	}
}
