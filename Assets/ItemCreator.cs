using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCreator : MonoBehaviour {
	public GameObject[] products;



	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {


	}

	public int invokeCart(int size, float speed){
		/*
		int errorCounter = 0;
		for(int i = 0; i < size; i++){
		*/

		yield return new WaitForSeconds (speed);
		int r = (int)(Random.Range (0, products.Length));
		Instantiate (products [r], transform.position, transform.rotation);
			//if error then errorCounter++;
		//return errorCounter;
	}
}
