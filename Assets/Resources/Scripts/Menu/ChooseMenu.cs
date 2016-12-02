using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChooseMenu : MonoBehaviour {


	int pChosing;
	public GameObject[] roteiroPlayers = new GameObject[2];
	public GameObject[] multimidiaPlayers = new GameObject[2];
	public GameObject[] programacaoPlayers = new GameObject[2];
	public GameObject readyBtn = new GameObject();
	public GameObject noBtn = new GameObject();


	void Start () {
		pChosing = 1;
		roteiroPlayers[0].SetActive(false);
		roteiroPlayers[1].SetActive(false);
		multimidiaPlayers[0].SetActive(false);
		multimidiaPlayers[1].SetActive(false);
		programacaoPlayers[0].SetActive(false);
		programacaoPlayers[1].SetActive(false);
		readyBtn.GetComponent<Button>().interactable = false;
		noBtn.GetComponent<Button>().interactable = false;
	}

	public void Click(string n)
	{
		if (pChosing < 3)
		{
			switch (n)
			{
				case "Rolthay-ru":
					PlayerPrefs.SetInt("P" + pChosing, 1);
					roteiroPlayers[pChosing - 1].SetActive(true);
					pChosing++;
					noBtn.GetComponent<Button>().interactable = true;
					break;
				case "Múhl-Teem-Idhia":
					PlayerPrefs.SetInt("P" + pChosing, 2);
					multimidiaPlayers[pChosing - 1].SetActive(true);
					pChosing++;
					noBtn.GetComponent<Button>().interactable = true;
					break;
				case "Prohgam Mason":
					PlayerPrefs.SetInt("P" + pChosing, 3);
					programacaoPlayers[pChosing - 1].SetActive(true);
					pChosing++;
					noBtn.GetComponent<Button>().interactable = true;
					break;
			}
		}

		if(pChosing == 3)
		{
			readyBtn.GetComponent<Button>().interactable = true;
		}
	}

	public void ready()
	{
		Application.LoadLevel("Jogo");
	}

	public void no()
	{
		pChosing = 1;
		roteiroPlayers[0].SetActive(false);
		roteiroPlayers[1].SetActive(false);
		multimidiaPlayers[0].SetActive(false);
		multimidiaPlayers[1].SetActive(false);
		programacaoPlayers[0].SetActive(false);
		programacaoPlayers[1].SetActive(false);
		readyBtn.GetComponent<Button>().interactable = false;
		noBtn.GetComponent<Button>().interactable = false;
	}

}
