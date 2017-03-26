using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Carrito : MonoBehaviour {


	public Text items, karts;
	public int itemCount = 0,
	kartCount = 0;

	//Goals

	int size = 2;
	float speed = 5;

	// ITEM CREATOR
	public ItemCreator iCWait;


	public Carrito(int size, float speed){
		this.size = size;
		this.speed = speed;
	}

	// Use this for initialization
	void Start (){
		iCWait.invokeCart (this.size, this.speed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/*
	void OnCollisionEnter(Collision c){
		//Debug.Log (c.gameObject.layer);
		if (c.gameObject.layer == 8) {
			Destroy (c.gameObject);
			itemCount++;
			if (itemCount % 5 == 0) {
				itemCount = 0;
				kartCount++;
				karts.text = "Karts: " + kartCount;
				iCWait.increase (1.0f);
				//ic.setVelocity (0.5f);
		
			}
			items.text = "Items: " + itemCount;
		}
	}
	*/
}
