using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class offline : MonoBehaviour {
	string ip;
	string url4_on, url4_off, url17_on, url17_off;
	string url27_on, url27_off, url22_on, url22_off;
	bool state4, state17, state27, state22;
	public Image image4;
	public Image image17;
	public Image image27;
	public Image image22;
	public Sprite _on;
	public Sprite _off;


	void Start () {
		if (PlayerPrefs.GetInt("led1")==1) {
			image4.sprite = _on;
		} else if (PlayerPrefs.GetInt("led1")==0) {
			image4.sprite = _off;	
		}
		if (PlayerPrefs.GetInt("led2")==1) {
			image17.sprite = _on;
		} else if (PlayerPrefs.GetInt("led2")==0) {
			image17.sprite = _off;
		}
		if (PlayerPrefs.GetInt("led3")==1) {
			image27.sprite = _on;
		} else if (PlayerPrefs.GetInt("led3")==0) {
			image27.sprite = _off;	
		}
		if (PlayerPrefs.GetInt("led4")==1) {
			image22.sprite = _on;
		} else if (PlayerPrefs.GetInt("led4")==0) {
			image22.sprite = _off;	
		}
		
		ip = submit_bttn.ipaddrss;
		url4_on = "http://"+ip+"/pin4on.php";
		url4_off = "http://"+ip+"/pin4off.php";
		url17_on = "http://"+ip+"/pin17on.php";
		url17_off = "http://"+ip+"/pin17off.php";
		url27_on = "http://"+ip+"/pin27on.php";
		url27_off = "http://"+ip+"/pin27off.php";
		url22_on = "http://"+ip+"/pin22on.php";
		url22_off = "http://"+ip+"/pin22off.php";
		state4 = false;
		state17 = false;
		state27 = false;
		state22 = false;
		//Debug.Log (url);
	
	}
	public void click_4()
	{
		if (PlayerPrefs.GetInt("led1")==0) {
			StartCoroutine (fnc (url4_on));
			image4.sprite = _on;
			state4 = true;
			PlayerPrefs.SetInt ("led1", 1);
		} else {
			image4.sprite = _off;
			StartCoroutine (fnc (url4_off));
			state4 = false;
			PlayerPrefs.SetInt ("led1", 0);
		}
	}
	public void click_17()
	{
		if (PlayerPrefs.GetInt("led2")==0) {
			image17.sprite = _on;
			StartCoroutine (fnc (url17_on));
			state17 = true;
			PlayerPrefs.SetInt ("led2", 1);
		} else {
			image17.sprite = _off;
			StartCoroutine (fnc (url17_off));
			state17 = false;
			PlayerPrefs.SetInt ("led2", 0);
		}
	}
	public void click_27()
	{
		if (PlayerPrefs.GetInt("led3")==0) {
			image27.sprite = _on;
			StartCoroutine (fnc (url27_on));
			state27 = true;
			PlayerPrefs.SetInt ("led3", 1);
		} else {
			image27.sprite = _off;
			StartCoroutine (fnc (url27_off));
			state27 = false;
			PlayerPrefs.SetInt ("led3", 0);
		}
	}
	public void click_22()
	{
		if (PlayerPrefs.GetInt("led4")==0) {
			image22.sprite = _on;
			StartCoroutine (fnc (url22_on));
			state22 = true;
			PlayerPrefs.SetInt ("led4", 1);
		} else {
			image22.sprite = _off;
			StartCoroutine (fnc (url22_off));
			state22 = false;
			PlayerPrefs.SetInt ("led4", 0);
		}
	}
	void Update () {
		if (Application.platform == RuntimePlatform.Android)
		{
			if (Input.GetKey(KeyCode.Escape))
			{
				SceneManager.LoadScene (1);
			}
		}
}

	IEnumerator fnc(string url)
	{
		WWW xyz = new WWW (url);
		yield return xyz;
	}
}
