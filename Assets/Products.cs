using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Products : MonoBehaviour {

	Vector3 dist;
	float posX, posY;
	bool moveZ = false;
	Utilities utilities;
	bool wasChecked;


	public string name;
	public int price;
	public int points;

	// Use this for initialization
	void Start () {
		utilities = GameObject.Find ("CashRegister").GetComponent<Utilities> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionStay(Collision c){
		if (c.gameObject.name == "Banda") {
			transform.position += Vector3.left * Time.deltaTime;
		}
	}

	void OnCollisionEnter(Collision c){
		if (c.gameObject.name == "Reader" && !wasChecked) {
			utilities.beep ();
			wasChecked = true;
		}
	}

	void OnTriggerEnter(Collider c){
		if (c.gameObject.name == "carritofloor") {
			if (!wasChecked) {

			}
			DestroyObject (this.gameObject);
		}
	}
		
}
