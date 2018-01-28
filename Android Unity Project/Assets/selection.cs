using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class selection : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.HasKey("state")) {
			//Debug.Log (PlayerPrefs.HasKey("state"));
			PlayerPrefs.SetInt("state",0);
			//PlayerPrefs.Save ();			
		}
		if (!PlayerPrefs.HasKey("led1")) {
			PlayerPrefs.SetInt ("led1", 0);
			//PlayerPrefs.Save ();
			//Debug.Log (PlayerPrefs.GetInt("led1"));
		}
		if (!PlayerPrefs.HasKey("led2")) {
			PlayerPrefs.SetInt ("led2", 0);
			//PlayerPrefs.Save ();
			//Debug.Log (PlayerPrefs.GetInt("led2"));
		}
		if (!PlayerPrefs.HasKey("led3")) {
			PlayerPrefs.SetInt ("led3", 0);
			//PlayerPrefs.Save ();
			//Debug.Log (PlayerPrefs.GetInt("led3"));
		}
		if (!PlayerPrefs.HasKey("led4")) {
			PlayerPrefs.SetInt ("led4", 0);
			//PlayerPrefs.Save ();
			//Debug.Log (PlayerPrefs.GetInt("led4"));
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.platform == RuntimePlatform.Android)
		{
			if (Input.GetKey(KeyCode.Escape))
			{
				Application.Quit ();
			}
		}

	
	}
	public void ofline()
	{
		PlayerPrefs.SetInt ("state", 0);
		PlayerPrefs.Save ();
		SceneManager.LoadScene (1);
		//Debug.Log(PlayerPrefs.GetInt("state"));
	}
	public void online()
	{
		PlayerPrefs.SetInt ("state", 1);
		PlayerPrefs.Save ();
		SceneManager.LoadScene (1);	
		//Debug.Log(PlayerPrefs.GetInt("state"));
	}
}