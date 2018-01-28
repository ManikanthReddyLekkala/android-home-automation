using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class submit_bttn : MonoBehaviour {
	public Text input;
	public static string ipaddrss;

	public void onclick(){
		if (PlayerPrefs.GetInt("state")==0) {
			ipaddrss = input.text;
			//Debug.Log (ipaddrss);
			//Debug.Log (PlayerPrefs.GetInt("state"));
			SceneManager.LoadScene(2);
		}
		if (PlayerPrefs.GetInt("state")==1) {
			ipaddrss = input.text;
			//Debug.Log (ipaddrss);
			//Debug.Log (PlayerPrefs.GetInt("state"));
			SceneManager.LoadScene(3);
		}
	
	}

	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.platform == RuntimePlatform.Android)
		{
			if (Input.GetKey(KeyCode.Escape))
			{
				SceneManager.LoadScene (0);
			}
	}
}
}