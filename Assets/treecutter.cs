using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class treecutter : MonoBehaviour {
	public Text dialogue;
	AudioSource audioData;
	// Use this for initialization
	void Start () {
		dialogue.text = "";
		audioData = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnMouseUp(){
		StartCoroutine(Damn());
		
	}
	 IEnumerator Damn()
    {
        print(Time.time);
        audioData.Play();
        dialogue.text = "I cannot stand seeing a green tree turn into ashes. Even leaves are rare nowadays. I'm just grinded some leaves and consume an acidic paste to survive! Will you have to do this to feed your sister?";
        yield return new WaitForSecondsRealtime(16);

        dialogue.text = "";
        print(Time.time);
    }
}
