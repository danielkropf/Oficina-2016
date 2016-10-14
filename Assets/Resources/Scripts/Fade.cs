using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Fade : MonoBehaviour {

	void Update () {
		Image img = this.GetComponent<Image>();
		float a = img.color.a;
		img.color = new Vector4(img.color.r, img.color.g, img.color.b, a -= 2.5f * Time.deltaTime);
		if (a <= 0) Destroy(this.gameObject);
	}
}
