using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	public GameObject attacking;
	public GameObject unitAttached;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp() {
		if (attacking != null)
		{
			Debug.LogError(attacking.GetComponent<Movement2>().life + " - " + unitAttached.GetComponent<Movement2>().damage);
			attacking.GetComponent<Movement2>().life -= unitAttached.GetComponent<Movement2>().damage;
			Debug.LogWarning(unitAttached.GetComponent<Movement2>().life + " - " + attacking.GetComponent<Movement2>().damage);
			unitAttached.GetComponent<Movement2>().life -= attacking.GetComponent<Movement2>().damage;

			GameObject temp = attacking;
			temp.GetComponent<Movement2>().ChangeColor(true);
			temp.GetComponent<Movement2>().started = false;
			temp.GetComponent<Movement2>().action = false;

			temp = null;
		}
	}
}
