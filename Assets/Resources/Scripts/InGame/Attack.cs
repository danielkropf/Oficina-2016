using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Attack : MonoBehaviour {

	public GameObject attacking;
	public GameObject unitAttached;
    private GameObject historico;
	int player;
	int playerEnemy;

	void Start () {
        historico = GameObject.FindGameObjectWithTag("Historic");
	}
	
	void Update () {

	}

	void OnMouseUp() {

		if (Main.playerTurn == 1)
		{
			player = 1; playerEnemy = 2;
		}
		else if (Main.playerTurn == 2) {
			player = 2;
			playerEnemy = 1;
		}

		if (attacking != null)
		{
			string e;
            string[] s = attacking.name.Split('(');
			if (attacking.name != "Mage(Clone)")
			{
				int x = unitAttached.GetComponent<Movement2>().damage ;
				attacking.GetComponent<Movement2>().life -= unitAttached.GetComponent<Movement2>().damage;
				e = "P" + player.ToString() + " " + "<color=#810>" +  s[0] + " -" + x.ToString() + " Vida" + "</color>";
				historico.GetComponent<Text>().text = e + "\n" + historico.GetComponent<Text>().text;
			}

			if (attacking.GetComponent<Movement2>().life <= 0)
			{
				if (Main.playerTurn == 1)
				{
					Main.gold[1] += attacking.GetComponent<Movement2>().goldToEarn;
					e = "P" + "2 +" + "<color=#FE3>" + attacking.GetComponent<Movement2>().goldToEarn + " Gold" + "</color>";
				}
				else
				{
					Main.gold[0] += attacking.GetComponent<Movement2>().goldToEarn;
					e = "P" + "1 +" + "<color=#FE3>" +  attacking.GetComponent<Movement2>().goldToEarn + " Gold" + "</color>";
				}
				historico.GetComponent<Text>().text = e + "\n" + historico.GetComponent<Text>().text;
			}

			s = unitAttached.name.Split('(');
			unitAttached.GetComponent<Movement2>().life -= attacking.GetComponent<Movement2>().damage;
			historico.GetComponent<Text>().text = "P" + playerEnemy.ToString() + "<color=#810>" + " " + s[0] + " -" + attacking.GetComponent<Movement2>().damage + " Vida" + "</color>" + "\n" + historico.GetComponent<Text>().text ;

			attacking.GetComponent<Movement2>().Abilities(unitAttached);
			if (unitAttached.GetComponent<Movement2>().life <= 0)
			{
				Main.gold[Main.playerTurn - 1] += unitAttached.GetComponent<Movement2>().goldToEarn;
				historico.GetComponent<Text>().text = "P" + player.ToString() + "<color=#FE3>" + " +" + unitAttached.GetComponent<Movement2>().goldToEarn + " Gold" + "</color>" + "\n" + historico.GetComponent<Text>().text ;
			}

			GameObject temp = attacking;
			temp.GetComponent<Movement2>().ChangeColor(true);
			temp.GetComponent<Movement2>().started = false;
			temp.GetComponent<Movement2>().action = false;
			temp.GetComponent<Movement2>().movs++;

			temp = null;
		}
	}
}
