using UnityEngine;
using System.Collections;

public class ChooseMenu : MonoBehaviour {


	int pChosing;


	void Start () {
		pChosing = 1;
	}

	public void Click(string n)
	{
		switch(n)
		{
			case "Rolthay-ru":
				PlayerPrefs.SetInt("P"+pChosing,1);
				pChosing++;
				break;
			case "Múhl-Teem-Idhia":
				PlayerPrefs.SetInt("P" + pChosing, 2);
				pChosing++;
				break;
			case "Prohgam Mason":
				PlayerPrefs.SetInt("P" + pChosing, 3);
				pChosing++;
				break;
		}

		if(pChosing > 2)
		{
			Application.LoadLevel("Jogo");
		}
	}


}
