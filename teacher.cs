using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class teacher : MonoBehaviour {
	public Text teacherNar;
	AudioSource audioData;
	public Text interact;
	// Use this for initialization
	void Start () {
		teacherNar.text = "";
		audioData = GetComponent<AudioSource>();
		interact.text="";
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
        teacherNar.text = "I used to be a teacher in this school. It's funny how a bit of education could've stopped this whole war.";
        yield return new WaitForSecondsRealtime(5);

        teacherNar.text = "Hey, you look hungry. You want my food? Take it. I don't want to live anymore. I'd rather starve to death.";
         yield return new WaitForSecondsRealtime(5);
         teacherNar.text = "";
        print(Time.time);
    }
}
