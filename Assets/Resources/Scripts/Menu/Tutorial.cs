using UnityEngine;
using System.Collections;

public class Tutorial : MonoBehaviour {

	public void BtnsTutorial(string go)
	{
		switch (go)
		{
			case "Next":
				this.gameObject.SetActive(false);
				break;

			case "Skip":
				Application.LoadLevel("SelecaoReinos");
				break;

			case "Game":
				Application.LoadLevel("SelecaoReinos");
				break;
		}
	}
}
