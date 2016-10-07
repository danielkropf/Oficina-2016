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
	public Sprite[] sprites = new Sprite[10];
	public GameObject[] prefabs_p2 = new GameObject[10];
	public Sprite[] sprites_p2 = new Sprite[10];
	public GameObject[] prefabs_p3 = new GameObject[10];
	public Sprite[] sprites_p3 = new Sprite[10];
	public int[] numsUsed = new int[4];
	private GameObject historico;

	void Start () {
		historico = GameObject.FindGameObjectWithTag("Historic");
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

		gold [0] = 20;
		gold [1] = 20;
		playerTurn = 1;

		ChangeDeck();

	}

	void Update () {
		gos = GameObject.FindGameObjectsWithTag("Unit");
		gos2 = GameObject.FindGameObjectsWithTag("Grid");
		goldtxt.GetComponent<Text>().text = "Ouro: " + gold[playerTurn - 1];
	}

	void ChangeDeck()
	{
		switch (PlayerPrefs.GetInt("P" + playerTurn))
		{
			case 1:
				for (int i = 0; i < 4; i++)
				{
                    buttonsToInvokeUnits[i].GetComponent<Image>().sprite = sprites[numsUsed[i]];
					buttonsToInvokeUnits[i].GetComponent<NormalUnit>().prefab = prefabs[numsUsed[i]].GetComponent<NormalUnit>().prefab;
					buttonsToInvokeUnits[i].GetComponent<NormalUnit>().gold = prefabs[numsUsed[i]].GetComponent<NormalUnit>().gold;
				}
				break;
			case 2:
				for (int i = 0; i < 4; i++)
				{
                    buttonsToInvokeUnits[i].GetComponent<Image>().sprite = sprites_p2[numsUsed[i]];
					buttonsToInvokeUnits[i].GetComponent<NormalUnit>().prefab = prefabs_p2[numsUsed[i]].GetComponent<NormalUnit>().prefab;
					buttonsToInvokeUnits[i].GetComponent<NormalUnit>().gold = prefabs_p2[numsUsed[i]].GetComponent<NormalUnit>().gold;
				}
				break;
			case 3:
				for (int i = 0; i < 4; i++)
				{
                    buttonsToInvokeUnits[i].GetComponent<Image>().sprite = sprites_p3[numsUsed[i]];
					buttonsToInvokeUnits[i].GetComponent<NormalUnit>().prefab = prefabs_p3[numsUsed[i]].GetComponent<NormalUnit>().prefab;
					buttonsToInvokeUnits[i].GetComponent<NormalUnit>().gold = prefabs_p3[numsUsed[i]].GetComponent<NormalUnit>().gold;
				}
				break;
		}
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
			gos[i].GetComponent<Movement2>().movs = 0;
			gos[i].GetComponent<Movement2>().ChangeColor(true);
			gos[i].GetComponent<Movement2>().started = false;
		}
		for (int i = 0; i < gos2.Length; i++)
		{
			gos2[i].GetComponent<Movment>().incomingNewUnit = null;
		}
		NormalUnit.cClick = true;

		for (int i = 0; i < buttonsToInvokeUnits.Length; i++) buttonsToInvokeUnits[i].GetComponent<NormalUnit>().invokedThisTurn = false;
		turn.GetComponent<Text>().text = "Turno: Jogador " + playerTurn;
		NormalUnit.alreadyClicked = !NormalUnit.alreadyClicked;

		ChangeDeck();
		historico.GetComponent<Text>().text = "P" + playerTurn + "<color=#FE3>" +" Gold + 3" + "</color>" + "\n" + historico.GetComponent<Text>().text;
	}
}
