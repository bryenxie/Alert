using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hospitalscripts : MonoBehaviour {
public Text hospital;
public Text interact;

AudioSource audioData;
	// Use this for initialization
	void Start () {
		hospital.text = "";
		audioData = GetComponent<AudioSource>();
		interact.text = "";
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
        hospital.text = "Oh God.... The Hospital... That was the explosion.. Who would do this? First the school, and now the Hospital.. What will I tell my sister?";
        yield return new WaitForSecondsRealtime(11);

         hospital.text = "";
        print(Time.time);
    }
}
