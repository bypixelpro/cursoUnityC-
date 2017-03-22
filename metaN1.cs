using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class metaN1 : MonoBehaviour {

	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == "Player")
			SceneManager.LoadScene ("fin");
	}
}
