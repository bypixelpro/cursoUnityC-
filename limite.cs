using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class limite : MonoBehaviour {

	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == "Player")
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
