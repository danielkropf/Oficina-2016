using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GetInfo : MonoBehaviour {

    public GameObject info;
	public GameObject skill;
	public string skillDescription;

	void Update()
	{
		skillDescription = this.gameObject.GetComponent<NormalUnit>().prefab.GetComponent<Movement2>().skillDescription;
	}

    public void ShowInfo(string evento)
    {
        switch(evento)
        {
            case "Enter":

                info.SetActive(true);
				if (skillDescription != "") skill.SetActive(true);
                info.transform.GetChild(2).GetComponent<Text>().text = "Vida: " + this.gameObject.GetComponent<NormalUnit>().prefab.GetComponent<Movement2>().life;
                info.transform.GetChild(1).GetComponent<Text>().text = "Dano: " + this.gameObject.GetComponent<NormalUnit>().prefab.GetComponent<Movement2>().damage;
                info.transform.GetChild(0).GetComponent<Text>().text = "Custo:" + this.gameObject.GetComponent<NormalUnit>().prefab.GetComponent<Movement2>().gold;
				skill.transform.GetChild(0).GetComponent<Text>().text = skillDescription;
                break;
            case "Exit":

                info.SetActive(false);
				skill.SetActive(false);
                break;
        }
    }
}
