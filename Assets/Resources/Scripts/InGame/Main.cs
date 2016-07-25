using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Main : MonoBehaviour {

	public static bool clickedAnArmy;
	public static GameObject armyClicked;
	public static int playerTurn = 1;
	public static GameObject[] gos;
	public static GameObject[] gos2;
	public GameObject[] buttonsToInvokeUnits = new GameObject[4];
	public GameObject turn;
	public static int[] gold = new int[2] {20,20};
	public GameObject goldtxt;
	private Text txt;
	public GameObject[] prefabs = new GameObject[10];
	public GameObject[] prefabs_p2 = new GameObject[10];
	public int[] numsUsed = new int[4];

	void Start () {

		for(int i = 0; i < 4; i++)
		{
			int t = Random.Range(0, 9);
			int n = 0;

			while(n < 4)
			{
				if(numsUsed[n] == t)
				{
					t = Random.Range(0,9);
					n = -1;
				}
				n++;
			}
			numsUsed[i] = t;
		}
		#region FAZ UM FOR PORRA
		for(int i = 0; i <= 3; i++)
		{
			//buttonsToInvokeUnits[i].GetComponent<Image>().sprite = prefabs[numsUsed[i]].GetComponent<Image>().sprite;
			buttonsToInvokeUnits[i].GetComponent<NormalUnit>().prefabs = new GameObject[2] { prefabs[numsUsed[i]].GetComponent<NormalUnit>().prefab, prefabs_p2[numsUsed[i]].GetComponent<NormalUnit>().prefab };
			//buttonsToInvokeUnits[i].GetComponent<NormalUnit>().gold = prefabs[numsUsed[i]].GetComponent<NormalUnit>().gold;
		}
		/*buttonsToInvokeUnits[0].GetComponent<Image>().sprite = prefabs[numsUsed[0]].GetComponent<Image>().sprite;
		buttonsToInvokeUnits[0].GetComponent<NormalUnit>().prefab = prefabs[numsUsed[0]].GetComponent<NormalUnit>().prefab;
		buttonsToInvokeUnits[0].GetComponent<NormalUnit>().gold = prefabs[numsUsed[0]].GetComponent<NormalUnit>().gold;

		buttonsToInvokeUnits[1].GetComponent<Image>().sprite = prefabs[numsUsed[1]].GetComponent<Image>().sprite;
		buttonsToInvokeUnits[1].GetComponent<NormalUnit>().prefab = prefabs[numsUsed[1]].GetComponent<NormalUnit>().prefab;
		buttonsToInvokeUnits[1].GetComponent<NormalUnit>().gold = prefabs[numsUsed[1]].GetComponent<NormalUnit>().gold;

		buttonsToInvokeUnits[2].GetComponent<Image>().sprite = prefabs[numsUsed[2]].GetComponent<Image>().sprite;
		buttonsToInvokeUnits[2].GetComponent<NormalUnit>().prefab = prefabs[numsUsed[2]].GetComponent<NormalUnit>().prefab;
		buttonsToInvokeUnits[2].GetComponent<NormalUnit>().gold = prefabs[numsUsed[2]].GetComponent<NormalUnit>().gold;

		buttonsToInvokeUnits[3].GetComponent<Image>().sprite = prefabs[numsUsed[3]].GetComponent<Image>().sprite;
		buttonsToInvokeUnits[3].GetComponent<NormalUnit>().prefab = prefabs[numsUsed[3]].GetComponent<NormalUnit>().prefab;
		buttonsToInvokeUnits[3].GetComponent<NormalUnit>().gold = prefabs[numsUsed[3]].GetComponent<NormalUnit>().gold;*/
		#endregion
	}

	void Update () {
		gos = GameObject.FindGameObjectsWithTag("Unit");
		gos2 = GameObject.FindGameObjectsWithTag("Grid");
		goldtxt.GetComponent<Text>().text = "Gold: " + gold[playerTurn - 1];
	}

	public void endTurn() {
		if (playerTurn == 1)
		{
			playerTurn = 2;
			gold[1] += 3;
		}
		else if (playerTurn == 2)
		{
			playerTurn = 1;
			gold[0] += 3;
		}

		for (int i = 0; i < gos.Length; i++)
		{
			gos[i].GetComponent<Movement2>().action = true;
			gos[i].GetComponent<Movement2>().ChangeColor(true);
			gos[i].GetComponent<Movement2>().started = false;
		}
		for (int i = 0; i < gos2.Length; i++)
		{
			gos2[i].GetComponent<Movment>().incomingNewUnit = null;
		}
		NormalUnit.cClick = true;

		for (int i = 0; i < buttonsToInvokeUnits.Length; i++) buttonsToInvokeUnits[i].GetComponent<NormalUnit>().invokedThisTurn = false;
		turn.GetComponent<Text>().text = "Turno: Player " + playerTurn;
	}
}
