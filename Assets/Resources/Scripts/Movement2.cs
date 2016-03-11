using UnityEngine;
using System.Collections;

public class Movement2 : MonoBehaviour {

    public GameObject placedOn;
	private Color32 color;
	public bool started;
	public int player;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		placedOn.GetComponent<Movment>().onMe = this.gameObject;
	}

	public void ChangeColor(bool b)
	{
		if (!b)
		{
			Debug.Log("clickou");
			if (placedOn.GetComponent<Movment>().immediatelyRight != null)
			{
				placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<SpriteRenderer>().color = new Color32(210, 50, 50, 255);
				placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().incoming = this.gameObject;
				if (placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp != null)
				{
					placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(210, 50, 50, 255);
					placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().incoming = this.gameObject;
				}
				if (placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown != null)
				{
					placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(210, 50, 50, 255);
					placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().incoming = this.gameObject;
				}
			}
			if (placedOn.GetComponent<Movment>().immediatelyDown != null)
			{
				placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(210, 50, 50, 255);
				placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().incoming = this.gameObject;
			}
			if (placedOn.GetComponent<Movment>().immediatelyLeft != null)
			{
				placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<SpriteRenderer>().color = new Color32(210, 50, 50, 255);
				placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().incoming = this.gameObject;
				if (placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp != null)
				{
					placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(210, 50, 50, 255);
					placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().incoming = this.gameObject;
				}
				if (placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown != null)
				{
					placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(210, 50, 50, 255);
					placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().incoming = this.gameObject;
				}
			}
			if (placedOn.GetComponent<Movment>().immediatelyUp != null)
			{
				placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(210, 50, 50, 255);
				placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().incoming = this.gameObject;
			}
			Main.armyClicked = this.gameObject;
			Main.clickedAnArmy = true;
		}
		else
		{
			Debug.Log("elsei vc");
			if (placedOn.GetComponent<Movment>().immediatelyRight != null)
			{
				placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
				placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().incoming = null;
				if (placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp != null)
				{
					placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
					placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().incoming = null;
				}
				if (placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown != null)
				{
					placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
					placedOn.GetComponent<Movment>().immediatelyRight.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().incoming = null;
				}
			}
			if (placedOn.GetComponent<Movment>().immediatelyDown != null)
			{
				placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
				placedOn.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().incoming = null;
			}
			if (placedOn.GetComponent<Movment>().immediatelyLeft != null)
			{
				placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
				placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().incoming = null;
				if (placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp != null)
				{
					placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
					placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().incoming = null;
				}
				if (placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown != null)
				{
					placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
					placedOn.GetComponent<Movment>().immediatelyLeft.GetComponent<Movment>().immediatelyDown.GetComponent<Movment>().incoming = null;
				}
			}
			if (placedOn.GetComponent<Movment>().immediatelyUp != null)
			{
				placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
				placedOn.GetComponent<Movment>().immediatelyUp.GetComponent<Movment>().incoming = null;
			}
			Main.armyClicked = null;
			Main.clickedAnArmy = false;
		}
	}

    void OnMouseUp()
	{
		if (Main.playerTurn == player && (!Main.clickedAnArmy || Main.armyClicked == this.gameObject))
		{
			ChangeColor(started);
			started = !started;
		}
	}
}
