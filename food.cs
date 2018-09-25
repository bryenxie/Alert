using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class food : MonoBehaviour {
	public Text teacherNar;
	public Text foodFound;
    public bool fdfound;
    waterBottleScript wt_script;
    AudioSource audioData;
    public Text interact;

	// Use this for initialization
	void Start () {
		teacherNar.text = "";
		foodFound.text = "";
		fdfound = false;
		interact.text = "";
	    
	    wt_script = GameObject.Find("Water Bottle").GetComponent<waterBottleScript>();
	    audioData = GetComponent<AudioSource>();

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
        teacherNar.text = "I used to be a teacher in this school. It's funny how a bit of education could've stopped this whole war.";
        yield return new WaitForSecondsRealtime(6);

        teacherNar.text = "Hey, you look hungry. You want my food? Take it. I don't want to live anymore. I'd rather starve to death.";
         yield return new WaitForSecondsRealtime(6);
         teacherNar.text = "";
        print(Time.time);
        gameObject.SetActive(false);
        foodFound.text = "you found food.";
        fdfound = true;

        if(wt_script.wtfound){
			SceneManager.LoadScene(2);

        }
        
           

     
    }
}
