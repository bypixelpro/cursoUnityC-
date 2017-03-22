using UnityEngine;
using System.Collections;

public class camara : MonoBehaviour {

	public GameObject bola;
	private Vector3 dist;

	// Use this for initialization
	void Start () {

		bola = GameObject.FindGameObjectWithTag ("Player");
		dist = transform.position;
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = bola.transform.position + dist;
	
	}
}
