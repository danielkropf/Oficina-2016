using UnityEngine;
using System.Collections;

public class Movement2 : MonoBehaviour {

    public GameObject placedOn;
	private Color32 color;
	public bool started;
	public int player;
	public bool action = true;
	public int life;
	public int damage;
	public GameObject attackMarker;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		placedOn.GetComponent<Movment>().onMe = this.gameObject;
		attackMarker.GetComponent<Attack>().unitAttached = this.gameObject;
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
					placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 255);
					placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().incoming = this.gameObject;
				}
				else
				{
					placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(true);
					placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = this.gameObject;
				}

				#region Right -> Up
				if (placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp != null)
				{
					if (placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe == null)
					{
						placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 255);
						placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().incoming = this.gameObject;
					}
					else
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
						placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 255);
						placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().incoming = this.gameObject;
					}
					else
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
					placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 255);
					placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().incoming = this.gameObject;
				}
				else
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
					placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 255);
					placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().incoming = this.gameObject;
				}
				else
				{
					placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(true);
					placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = this.gameObject;
				}

				if (placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp != null)
				{
					if (placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe == null)
					{
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 255);
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().incoming = this.gameObject;
					}
					else
					{
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(true);
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = this.gameObject;
					}
				}

				if (placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown != null)
				{
					if (placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe == null)
					{
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 255);
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().incoming = this.gameObject;
					}
					else
					{
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(true);
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = this.gameObject;
					}
				}
			}
			#endregion

			#region Up
			if (placedOn.GetComponent<Movment>().immediatelyUp != null)
			{
				if (placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().onMe == null)
				{
					placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 255);
					placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().incoming = this.gameObject;
				}
				else
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
					placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
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
						placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
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
						placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
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
					placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
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
					placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
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
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
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
						placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
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
					placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
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
		}
	}
}
