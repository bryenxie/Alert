﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bodies : MonoBehaviour {

	public Text deadbodies;
	public Text interact;
	AudioSource audioData;
	// Use this for initialization
	void Start () {
		deadbodies.text = "";
		interact.text = "";
		audioData = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onMouseEnter(){
		interact.text = "click to interact.";

	}
	public void onMouseExit(){
		interact.text = "";
	}

	public void OnMouseUp(){
		StartCoroutine(Damn());
		
	}
	 IEnumerator Damn()
    {
        print(Time.time);
        audioData.Play();
        deadbodies.text = "Oh God. So many deaths. I hope someone cleans this up before my sister sees it... Wait a minute... Since when did I start referring to dead bodies as pieces of garbage? I'm disgusted by myself.";
        yield return new WaitForSecondsRealtime(20);

         deadbodies.text = "";
        print(Time.time);
    }
}
