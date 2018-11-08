using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class line : MonoBehaviour {
		public Text l;
		AudioSource audioData;
		public Text interact;
	// Use this for initialization
	void Start () {
		l.text = "";
		audioData = GetComponent<AudioSource>();
		interact.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnMouseUp(){
		StartCoroutine(Damn());
		
	}
	public void onMouseEnter(){
		interact.text = "click to interact.";

	}
	public void onMouseExit(){
		interact.text = "";
	}
	 IEnumerator Damn()
    {
        print(Time.time);
        audioData.Play();
        l.text = "The UN volunteers are here with the rations, but the line is too big. I won't be able to get food by the end of the day.";
        yield return new WaitForSecondsRealtime(7);

         l.text = "";
        print(Time.time);
    }
}
