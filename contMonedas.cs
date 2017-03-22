using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class contMonedas : MonoBehaviour {

	private Text texto;
	public int monedas = 0;


	// Use this for initialization
	void Start () {
		texto = GetComponent<Text> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		texto.text = "Puntos: " + monedas;
	}
}
