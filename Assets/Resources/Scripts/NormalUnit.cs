using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NormalUnit : MonoBehaviour {

	private GameObject[] gos;
	public GameObject[] kings = new GameObject[2];
	private GameObject myKing;
	public GameObject prefab;
	private bool alreadyClicked;
	public bool invokedThisTurn;
	public GameObject vida;
	public GameObject dano;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeColor(bool b)
	{

		if (!b)
		{
			#region Started = true
			Debug.Log("clickou");

			#region Right
			if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight != null)
			{
				if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().onMe == null)
				{
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 255);
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().incomingNewUnit = prefab;
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().playerNewUnitAttached = myKing.GetComponent<Movement2>().player;
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().button = this.gameObject;
				}

				#region Right -> Up
				if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp != null)
				{
					if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe == null)
					{
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 255);
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().incomingNewUnit = prefab;
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().playerNewUnitAttached = myKing.GetComponent<Movement2>().player;
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().button = this.gameObject;
					}
				}
				#endregion

				#region Right -> Down
				if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown != null)
				{
					if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe == null)
					{
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 255);
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().incomingNewUnit = prefab;
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().playerNewUnitAttached = myKing.GetComponent<Movement2>().player;
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().button = this.gameObject;
					}
				}
				#endregion
			}
			#endregion

			#region Down
			if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyDown != null)
			{
				if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe == null)
				{
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 255);
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().incomingNewUnit = prefab;
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().playerNewUnitAttached = myKing.GetComponent<Movement2>().player;
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().button = this.gameObject;
				}
			}
			#endregion

			#region Left
			if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft != null)
			{
				if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().onMe == null)
				{
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 255);
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().incomingNewUnit = prefab;
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().playerNewUnitAttached = myKing.GetComponent<Movement2>().player;
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().button = this.gameObject;
				}

				#region Left -> Up
				if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp != null)
				{
					if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe == null)
					{
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 255);
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().incomingNewUnit = prefab;
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().playerNewUnitAttached = myKing.GetComponent<Movement2>().player;
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().button = this.gameObject;
					}
				}
				#endregion

				#region Left -> Down
				if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown != null)
				{
					if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe == null)
					{
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 255);
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().incomingNewUnit = prefab;
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().playerNewUnitAttached = myKing.GetComponent<Movement2>().player;
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().button = this.gameObject;
					}
				}
				#endregion
			}
			#endregion

			#region Up
			if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyUp != null)
			{
				if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe == null)
				{
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 255);
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().incomingNewUnit = prefab;
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().playerNewUnitAttached = myKing.GetComponent<Movement2>().player;
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().button = this.gameObject;
				}
			}
			#endregion

			Main.armyClicked = prefab;
			Main.clickedAnArmy = true;

			#endregion
		}
		else
		{
			#region Started = False

			#region Right
			if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight != null)
			{
				if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().onMe == null)
				{
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().incomingNewUnit = null;
				}
				else
				{
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(false);
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = null;
				}

				#region Right -> Up
				if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp != null)
				{
					if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe == null)
					{
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().incomingNewUnit = null;
					}
					else
					{
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(false);
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = null;
					}
				}
				#endregion

				#region Right -> Down
				if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown != null)
				{
					if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe == null)
					{
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().incomingNewUnit = null;
					}
					else
					{
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(false);
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = null;
					}
				}
				#endregion
			}
			#endregion

			#region Down
			if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyDown != null)
			{
				if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe == null)
				{
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().incomingNewUnit = null;
				}
				else
				{
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(false);
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = null;
				}
			}
			#endregion

			#region Left
			if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft != null)
			{
				if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().onMe == null)
				{
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().incomingNewUnit = null;
				}
				else
				{
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(false);
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = null;
				}

				if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp != null)
				{
					if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe == null)
					{
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().incomingNewUnit = null;
					}
					else
					{
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(false);
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = null;
					}
				}

				if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown != null)
				{
					if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe == null)
					{
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().incomingNewUnit = null;
					}
					else
					{
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(false);
						myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = null;
					}
				}
			}
			#endregion

			#region Up
			if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyUp != null)
			{
				if (myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe == null)
				{
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().incomingNewUnit = null;
				}
				else
				{
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(false);
					myKing.GetComponent<Movement2>().placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = null;
				}
			}
			#endregion

			Main.armyClicked = null;
			Main.clickedAnArmy = false;

			#endregion
		}
	}

	public void InvokeUnit() {
		if (!invokedThisTurn)
		{
			if (Main.playerTurn == 1) myKing = kings[0];
			else myKing = kings[1];

			ChangeColor(alreadyClicked);
		}
	}

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
}
