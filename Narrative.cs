using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Narrative : MonoBehaviour {
	public Text narration;

	// Use this for initialization
	void Start () {
		
		 StartCoroutine(Beginning());
    }

    IEnumerator Beginning()
    {
        print(Time.time);
        narration.text = "You're finally up! There was an explosion outside and people were screaming! Can you check it out? Also, can you get food and water? I'm starving.";
        yield return new WaitForSecondsRealtime(10);
        narration.text = "";
        print(Time.time);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
