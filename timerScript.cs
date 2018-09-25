using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class timerScript : MonoBehaviour {

    public Text timerText;
    private float startTime;
	// Use this for initialization
	void Start () {
		startTime = Time.time + 300;
		
	}
	
	// Update is called once per frame
	void Update () {
		float t = startTime - Time.time;
		string minutes = ((int) t / 60).ToString();
		string seconds = (t % 60).ToString("f2");

		timerText.text = minutes + ":" + seconds;
		
		if( t <= 0)
		{
			SceneManager.LoadScene(3);
		}
	}
}
