using UnityEngine;
using System.Collections;

public class moneda : MonoBehaviour {

	contMonedas contmonedas;

	// Use this for initialization
	void Start () {
		contmonedas = GameObject.FindGameObjectWithTag ("contMonedas").GetComponent<contMonedas> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == "Player")
			contmonedas.monedas++;
			gameObject.SetActive (false);
	}
}
