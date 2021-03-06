﻿using UnityEngine;
using System.Collections;

public class Movment : MonoBehaviour {

    public GameObject immediatelyRight;
    public GameObject immediatelyLeft;
    public GameObject immediatelyUp;
    public GameObject immediatelyDown;
	public GameObject onMe;
	public GameObject incoming;
	public GameObject incomingNewUnit;
	private GameObject instantiedUnit;
	public GameObject button;
	public int playerNewUnitAttached;
	public GameObject vida;
	public GameObject dmg;

	void OnMouseUp() {
		if (incoming != null)
		{
			NormalUnit.cClick = true;
			GameObject temp = incoming;
			temp.GetComponent<Movement2>().ChangeColor(true);
			temp.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, temp.transform.position.z);
			temp.GetComponent<Movement2>().placedOn.GetComponent<Movment>().onMe = null;
			temp.GetComponent<Movement2>().placedOn = this.gameObject;
            temp.GetComponent<Movement2>().arroundMe = RandomF.FindSurroundings(this.gameObject);
			temp.GetComponent<Movement2>().started = false;
			temp.GetComponent<Movement2>().action = false;
			temp.GetComponent<Movement2>().movs++;

			if (temp.GetComponent<Movement2>().movs <= 1 && temp.name == "Garen(Clone)")
				temp.GetComponent<Movement2>().action = true;

			onMe = incoming;
			incoming = null;
			temp = null;
		}
		if(incomingNewUnit != null)
		{
			Main.gold[Main.playerTurn - 1] -= incomingNewUnit.GetComponent<Movement2>().gold;
			instantiedUnit = (Instantiate(incomingNewUnit, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, -1), Quaternion.identity)) as GameObject;
			instantiedUnit.GetComponent<Movement2>().placedOn = this.gameObject;
			instantiedUnit.GetComponent<Movement2>().player = playerNewUnitAttached;
			instantiedUnit.GetComponent<Movement2>().action = false;
			instantiedUnit.GetComponent<Movement2>().vida = vida;
			instantiedUnit.GetComponent<Movement2>().dano = dmg;
			button.GetComponent<NormalUnit>().ChangeColor(true);
			button.GetComponent<NormalUnit>().invokedThisTurn = true;
		}
	}
}