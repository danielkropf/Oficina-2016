using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Movement2 : MonoBehaviour {

    public GameObject placedOn;
	private Color32 color;
	public bool started;
	public int player;
	public bool action = true;
	public int movs = 0;
	public int life;
	public int damage;
	public int bonusDmg;
	public GameObject attackMarker;
	public GameObject vida;
	public GameObject dano;
	public bool king;
	public int gold;
	public int goldToEarn;
	public GameObject[] btns;
	public string skillDescription;
    public GameObject[] arroundMe;
	Text txt;
	
	void Start () {
        arroundMe = RandomF.FindSurroundings(placedOn);
	}

	public void Abilities(GameObject go)
	{
		switch (this.name)
		{
			case "Goat(Clone)":
                if (go.GetComponent<Movement2>().damage > 1) go.GetComponent<Movement2>().damage--;
				break;
			case "High Warrior(Clone)":
				if (this.GetComponent<Movement2>().life < 8) this.GetComponent<Movement2>().life++;
				break;
			case "Thief(Clone)":
				if (Main.playerTurn == 1 && Main.gold[1] >= this.GetComponent<Movement2>().damage) Main.gold[0] += this.GetComponent<Movement2>().damage; Main.gold[1] -= this.GetComponent<Movement2>().damage;
				if (Main.playerTurn == 2 && Main.gold[0] >= this.GetComponent<Movement2>().damage) Main.gold[0] -= this.GetComponent<Movement2>().damage; Main.gold[1] += this.GetComponent<Movement2>().damage;
				break;
			default:
				break;
		}
	}

	void Update () {
		placedOn.GetComponent<Movment>().onMe = this.gameObject;
		attackMarker.GetComponent<Attack>().unitAttached = this.gameObject;
		if (life <= 0) Destroy(this.gameObject);
		goldToEarn = gold / 3 * 2;
        if (this.name.Equals("Viking(Clone)")) damage = 1 + (8 - life);
        if (this.gameObject.name.Equals("king cartoon") || this.gameObject.name.Equals("enemy cartoon"))
        {
            if (life <= 0) Application.LoadLevel("Menu");
        }
        if (PlayerPrefs.GetInt("P" + player) == 1)
        {
            for (int i = 0; i < arroundMe.Length; i++)
            {
                if (arroundMe[i] != null)
                {
                    if (arroundMe[i].GetComponent<Movment>().onMe != null)
                    {
                        if (arroundMe[i].GetComponent<Movment>().onMe.GetComponent<Movement2>().king)
                        {
                            if (arroundMe[i].GetComponent<Movment>().onMe.GetComponent<Movement2>().player == player)
                            {
                                bonusDmg = 1;
                                i = 10;
                            }
                            else
                                bonusDmg = 0;
                        }
                    }
                    else
                        bonusDmg = 0;
                }
                else
                    bonusDmg = 0;
            }
        }

	}

	public void ChangeColor(bool b)
	{
		
		if (!b)
		{
			#region Started = true
            for (int i = 0; i < arroundMe.Length; i++)
            {
                if (arroundMe[i] != null)
                {
                    if (arroundMe[i].GetComponent<Movment>().onMe == null)
                    {
                        arroundMe[i].GetComponent<SpriteRenderer>().color = new Color32(29, 243, 21, 125);
                        arroundMe[i].GetComponent<Movment>().incoming = this.gameObject;
                    }

                    else if (arroundMe[i].GetComponent<Movment>().onMe.GetComponent<Movement2>().player != player)
                    {
                        arroundMe[i].GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(true);
                        arroundMe[i].GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<SpriteRenderer>().color = new Color32(255, 0, 0, 132);
                        arroundMe[i].GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = this.gameObject;
                    }

                    else if (arroundMe[i].GetComponent<Movment>().onMe.GetComponent<Movement2>().player == player)
                    {
                        if (PlayerPrefs.GetInt("P" + player) == 3 && king)
                        {
                            arroundMe[i].GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(true);
                            arroundMe[i].GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 0, 132);
                            arroundMe[i].GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().Troca = this.gameObject;
                            arroundMe[i].GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().Trocado = arroundMe[i].GetComponent<Movment>().onMe;
                        }
                    }
                }
            }

			Main.armyClicked = this.gameObject;
			Main.clickedAnArmy = true;

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
                        arroundMe[i].GetComponent<Movment>().incoming = null;
                    }

                    else if (arroundMe[i].GetComponent<Movment>().onMe.GetComponent<Movement2>().player != player)
                    {
                        arroundMe[i].GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(false);
                        arroundMe[i].GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().attacking = null;
                    }

                    else if (arroundMe[i].GetComponent<Movment>().onMe.GetComponent<Movement2>().player == player)
                    {
                        if (PlayerPrefs.GetInt("P" + player) == 3 && king)
                        {
                            arroundMe[i].GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.SetActive(false);
                            arroundMe[i].GetComponent<Movment>().onMe.GetComponent<Movement2>().attackMarker.GetComponent<Attack>().Troca = null;
                        }
                    }
                }
            }

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
		dano.GetComponent<Text>().text = "Dano: " + (damage + bonusDmg);
	}

	void OnMouseExit()
	{
		vida.GetComponent<Text>().text = "Vida: ";
		dano.GetComponent<Text>().text = "Dano: ";
	}
}
