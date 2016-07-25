using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	public GameObject attacking;
	public GameObject unitAttached;

	void Start () {
	
	}
	
	void Update () {
	
	}

	void OnMouseUp() {
		if (attacking != null)
		{
			attacking.GetComponent<Movement2>().life -= unitAttached.GetComponent<Movement2>().damage;
			if (attacking.GetComponent<Movement2>().life <= 0)
				if (Main.playerTurn == 1) Main.gold[1] += attacking.GetComponent<Movement2>().goldToEarn;
				else Main.gold[0] += attacking.GetComponent<Movement2>().goldToEarn;
			unitAttached.GetComponent<Movement2>().life -= attacking.GetComponent<Movement2>().damage;
			attacking.GetComponent<Movement2>().Abilities(unitAttached);
			if (unitAttached.GetComponent<Movement2>().life <= 0) Main.gold[Main.playerTurn - 1] += unitAttached.GetComponent<Movement2>().goldToEarn;

			GameObject temp = attacking;
			temp.GetComponent<Movement2>().ChangeColor(true);
			temp.GetComponent<Movement2>().started = false;
			temp.GetComponent<Movement2>().action = false;

			temp = null;
		}
	}
}
