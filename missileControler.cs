using UnityEngine;
using System.Collections;

public class missileControler : MonoBehaviour {

	// Use this for initialization
	public float speed;

	float destroyIn = 300;
	public GameObject explosion;
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * Time.deltaTime * speed;

		destroyIn = destroyIn - 1;
		if (destroyIn < 0) {
			DoDestroy ();
		}
	}
			

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Destroy") {
			Destroy (other.gameObject);
		}
		DoDestroy ();
	}

	void DoDestroy(){
		Instantiate (explosion, transform.position, transform.rotation);
		Destroy (gameObject);
	}
}
