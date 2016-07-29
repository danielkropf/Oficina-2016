﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Movement2 : MonoBehaviour {

    public GameObject placedOn;
	private Color32 color;
	public bool started;
	public int player;
	public bool action = true;
	public int life;
	public int damage;
	public GameObject attackMarker;
	public GameObject vida;
	public GameObject dano;
	public bool king;
	public int gold;
	public int goldToEarn;
	public GameObject[] btns;
	Text txt;
	
	void Start () {

	}

	public void Abilities(GameObject go)
	{
		switch (this.name)
		{
			case "Goat(Clone)":
				go.GetComponent<Movement2>().damage--;
				break;
			default:
				Debug.Log(this.name);
				break;
		}
	}

	void Update () {
		placedOn.GetComponent<Movment>().onMe = this.gameObject;
		attackMarker.GetComponent<Attack>().unitAttached = this.gameObject;
		if (life <= 0) Destroy(this.gameObject);
		goldToEarn = gold / 3 * 2;
	}

	public void ChangeColor(bool b)
	{
		
		if (!b)
		{
			#region Started = true
			Debug.Log("clickou");

			#region Right
			if (placedOn.GetComponent<Movment>().immediatelyRight != null)
			{
				if (placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().onMe == null)
				{
					placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 125);
					placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().incoming = this.gameObject;
				}
				else if(placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().onMe.GetComponent<Movement2>().player != player)
				{
					placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(true);
					placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = this.gameObject;
				}

				#region Right -> Up
				if (placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp != null)
				{
					if (placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe == null)
					{
						placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 125);
						placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().incoming = this.gameObject;
					}
					else if (placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe.GetComponent<Movement2>().player != player)
					{
						placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(true);
						placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = this.gameObject;
					}
				}
				#endregion

				#region Right -> Down
				if (placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown != null)
				{
					if (placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe == null)
					{
						placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 125);
						placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().incoming = this.gameObject;
					}
					else if (placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe.GetComponent<Movement2>().player != player)
					{
						placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(true);
						placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = this.gameObject;
					}
				}
				#endregion
			}
			#endregion

			#region Down
			if (placedOn.GetComponent<Movment>().immediatelyDown != null)
			{
				if (placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe == null)
				{
					placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 125);
					placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().incoming = this.gameObject;
				}
				else if (placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe.GetComponent<Movement2>().player != player)
				{
					placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(true);
					placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = this.gameObject;
				}
			}
			#endregion

			#region Left
			if (placedOn.GetComponent<Movment>().immediatelyLeft != null)
			{
				if (placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().onMe == null)
				{
					placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 125);
					placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().incoming = this.gameObject;
				}
				else if (placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().onMe.GetComponent<Movement2>().player != player)
				{
					placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(true);
					placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = this.gameObject;
				}

				#region Left -> Up
				if (placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp != null)
				{
					if (placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe == null)
					{
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 125);
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().incoming = this.gameObject;
					}
					else if (placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe.GetComponent<Movement2>().player != player)
					{
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(true);
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = this.gameObject;
					}
				}
				#endregion

				#region Left -> Down
				if (placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown != null)
				{
					if (placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe == null)
					{
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 125);
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().incoming = this.gameObject;
					}
					else if (placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe.GetComponent<Movement2>().player != player)
					{
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(true);
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = this.gameObject;
					}
				}
				#endregion
			}
			#endregion

			#region Up
			if (placedOn.GetComponent<Movment>().immediatelyUp != null)
			{
				if (placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe == null)
				{
					placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 125);
					placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().incoming = this.gameObject;
				}
				else if (placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe.GetComponent<Movement2>().player != player)
				{
					placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(true);
					placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = this.gameObject;
				}
			}
			#endregion

			Main.armyClicked = this.gameObject;
			Main.clickedAnArmy = true;

			#endregion
		}
		else
		{
			#region Started = False

			#region Right
			if (placedOn.GetComponent<Movment>().immediatelyRight != null)
			{
				if (placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().onMe == null)
				{
					placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 125);
					placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().incoming = null;
				}
				else
				{
					placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(false);
					placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = null;
				}

				#region Right -> Up
				if (placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp != null)
				{
					if (placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe == null)
					{
						placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 125);
						placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().incoming = null;
					}
					else
					{
						placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(false);
						placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = null;
					}
				}
				#endregion

				#region Right -> Down
				if (placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown != null)
				{
					if (placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe == null)
					{
						placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 125);
						placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().incoming = null;
					}
					else
					{
						placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(false);
						placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = null;
					}
				}
				#endregion
			}
			#endregion

			#region Down
			if (placedOn.GetComponent<Movment>().immediatelyDown != null)
			{
				if (placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe == null)
				{
					placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 125);
					placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().incoming = null;
				}
				else
				{
					placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(false);
					placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = null;
				}
			}
			#endregion

			#region Left
			if (placedOn.GetComponent<Movment>().immediatelyLeft != null)
			{
				if (placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().onMe == null)
				{
					placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 125);
					placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().incoming = null;
				}
				else
				{
					placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(false);
					placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = null;
				}

				if (placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp != null)
				{
					if (placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe == null)
					{
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 125);
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().incoming = null;
					}
					else
					{
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(false);
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = null;
					}
				}

				if (placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown != null)
				{
					if (placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe == null)
					{
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 125);
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().incoming = null;
					}
					else
					{
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(false);
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = null;
					}
				}
			}
			#endregion

			#region Up
			if (placedOn.GetComponent<Movment>().immediatelyUp != null)
			{
				if (placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe == null)
				{
					placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 125);
					placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().incoming = null;
				}
				else
				{
					placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(false);
					placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = null;
				}
			}
			#endregion

			Main.armyClicked = null;
			Main.clickedAnArmy = false;

			#endregion
		}
	}

    void OnMouseUp()
	{
		if (Main.playerTurn == player && (!Main.clickedAnArmy || Main.armyClicked == this.gameObject) && action)
		{
			ChangeColor(started);
			started = !started;
			NormalUnit.cClick = !started;
		}
	}

	void OnMouseOver()
	{
		vida.GetComponent<Text>().text = "Vida: " + life;
		dano.GetComponent<Text>().text = "Dano: " + damage;
	}
	void OnMouseExit()
	{
		vida.GetComponent<Text>().text = "Vida: ";
		dano.GetComponent<Text>().text = "Dano: ";
	}
}
