using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class meta : MonoBehaviour {
	


	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == "Player")
			SceneManager.LoadScene ("nivel2");
	}
}
