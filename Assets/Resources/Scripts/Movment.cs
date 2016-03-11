using UnityEngine;
using System.Collections;

public class Movment : MonoBehaviour {

    public GameObject immediatelyRight;
    public GameObject immediatelyLeft;
    public GameObject immediatelyUp;
    public GameObject immediatelyDown;
	public GameObject onMe;
	public GameObject incoming;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp() {
		if (incoming != null)
		{
			GameObject temp = incoming;
			temp.GetComponent<Movement2>().ChangeColor(true);
			temp.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, temp.transform.position.z);
			temp.GetComponent<Movement2>().placedOn.GetComponent<Movment>().onMe = null;
			temp.GetComponent<Movement2>().placedOn = this.gameObject;
			temp.GetComponent<Movement2>().started = false;
			temp.GetComponent<Movement2>().action = false;
			onMe = incoming;
			incoming = null;
			temp = null;
		}
	}
}