using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NormalUnit : MonoBehaviour {

	private GameObject[] gos;
	public GameObject[] kings = new GameObject[2];
	private GameObject myKing;
	public GameObject prefab;
	public GameObject[] prefabs;
	public static bool alreadyClicked;
	public bool invokedThisTurn;
	public GameObject vida;
	public GameObject dano;
	public int gold;
	public static bool cClick = true;
    private GameObject[] arroundMe;

	void Start () {
        arroundMe = new GameObject[8];
	}
	
	void Update ()
	{
		if (gold > Main.gold[Main.playerTurn - 1] || !cClick)
		{
			this.gameObject.GetComponent<Button>().interactable = false;
		}
		else
		{
			this.gameObject.GetComponent<Button>().interactable = true;
		}
	}

	public void ChangeColor(bool b)
	{
        arroundMe = RandomF.FindSurroundings(myKing.GetComponent<Movement2>().placedOn);
		if (!b)
		{
			#region Started = true
            for (int i = 0; i < arroundMe.Length; i++)
            {
                if (arroundMe[i] != null)
                {
                    if (arroundMe[i].GetComponent<Movment>().onMe == null)
                    {
                        arroundMe[i].GetComponent<SpriteRenderer>().color = new Color32(0, 50, 255, 135);
                        arroundMe[i].GetComponent<Movment>().incomingNewUnit = prefab;
                        arroundMe[i].GetComponent<Movment>().playerNewUnitAttached = myKing.GetComponent<Movement2>().player;
                        arroundMe[i].GetComponent<Movment>().button = this.gameObject;
                    }
                }
            }

			Main.armyClicked = prefab;
			Main.clickedAnArmy = true;
			Main.btnClicked = this.gameObject;

			#endregion
		}
		else
		{
			#region Started = False

            for (int i = 0; i < arroundMe.Length; i++)
            {
                if (arroundMe[i] != null)
                {
                    if (arroundMe[i].GetComponent<Movment>().onMe == null)
                    {
                        arroundMe[i].GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 125);
                        arroundMe[i].GetComponent<Movment>().incomingNewUnit = null;
                    }
                    else
                    {
                        arroundMe[i].GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(false);
                        arroundMe[i].GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = null;
                    }
                }
            }

			Main.armyClicked = null;
			Main.clickedAnArmy = false;
			Main.btnClicked = null;

			#endregion
		}
	}

	public void InvokeUnit() {
		if (!invokedThisTurn)
		{
			if (Main.playerTurn == 1) myKing = kings[0];
			else myKing = kings[1];

			ChangeColor(alreadyClicked);
			alreadyClicked = !alreadyClicked;
		}
	}

	#region Inutil (Por enquanto)
	void ShowLife()
	{
		vida.GetComponent<Text>().text = "Vida: " + prefab.GetComponent<Movement2>().life;
		dano.GetComponent<Text>().text = "Dano: " + prefab.GetComponent<Movement2>().damage;
	}
	void HideLife()
	{
		vida.GetComponent<Text>().text = "Vida: ";
		dano.GetComponent<Text>().text = "Dano: ";
	}
	#endregion
}