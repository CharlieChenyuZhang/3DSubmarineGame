using UnityEngine;
using System.Collections;

public class SubmarineController : MonoBehaviour {

	public CharacterController cControl;
	public Transform submarineHolder;
	public float speed;
	public float rotationSpeed;
	public GameObject missile;
	public Transform fireSpot;

	// Use this for initialization
	void Start () {
		cControl = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		// Time.deltaTime the time between each frame
		cControl.Move (submarineHolder.forward * Time.deltaTime * speed);
		submarineHolder.rotation = Quaternion.Slerp (submarineHolder.rotation,Camera.main.transform.rotation, Time.deltaTime * rotationSpeed);
		// remember to assign missile and firespot!
		if (GvrViewer.Instance.Triggered) {
			Instantiate (missile, fireSpot.position, fireSpot.rotation);
		}
	}
}
