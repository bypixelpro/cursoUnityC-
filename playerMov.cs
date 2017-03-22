using UnityEngine;
using System.Collections;

public class playerMov : MonoBehaviour {

	public float velocidad = 11.0f;
	public bool suelo = false;
	public Rigidbody bola;

	// Use this for initialization
	void Start () {

		bola = GetComponent<Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		float movHor = Input.GetAxis ("Horizontal");
		float movVer = Input.GetAxis ("Vertical");
		Vector3 fuerza = new Vector3 (movHor, movVer, 0.0f);

		if (suelo) {
			bola.AddForce (fuerza * velocidad);
		}

	}

	void OnCollisionEnter(){
		
		suelo = true;

		print ("Suelo");
	}
	void OnCollisionExit(){
		suelo = false;
		print ("En el aire");

	}


}
