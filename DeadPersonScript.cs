using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeadPersonScript : MonoBehaviour {
	public Text dead;

	// Use this for initialization
	void Start () {
		dead.text=""; 
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
        dead.text = "This person has a water bottle next to them, but I don't know if they're dead or not... If I don't take it, I risk my sister's life. If I do take it, I risk his...";
        yield return new WaitForSecondsRealtime(10);
        dead.text = "";
        print(Time.time);
    }
}
