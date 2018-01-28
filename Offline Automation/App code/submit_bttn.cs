using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class submit_bttn : MonoBehaviour {
	public Text input;
	public static string ipaddrss;

	public void onclick(){
	
		ipaddrss = input.text;
		//Debug.Log (ipaddrss);
		SceneManager.LoadScene(1);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
