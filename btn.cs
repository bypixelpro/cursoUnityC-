using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class btn : MonoBehaviour {

	public Button btnStart;

	// Use this for initialization
	void Start () {
		Button btnstart = btnStart.GetComponent<Button> ();
		btnstart.onClick.AddListener (startOnClick);

	
	}

	void startOnClick (){
		Debug.Log ("Has pulsado el boton de inicio");
		SceneManager.LoadScene ("nivel2");
	}
}
