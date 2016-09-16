using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public void ClickButton(string go)
	{
		switch(go)
		{
			case "Jogar":
				Application.LoadLevel("SelecaoReinos");
				break;

			case "Creditos":
				Application.LoadLevel("Creditos");
				break;

			case "Opcoes":
				Application.LoadLevel("Opções");
				break;

			case "Sair":
				Application.Quit();
				break;

			case "Menu":
				Application.LoadLevel("Menu");
				break;
		}
	}
}
