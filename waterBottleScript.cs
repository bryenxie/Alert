using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class waterBottleScript : MonoBehaviour {

	public bool water;
	public Text waterFound;
	public Text dead;
    public bool wtfound;
    food food_script;
    AudioSource audioData;
    public Text interact;


	// Use this for initialization
	void Start () {
		waterFound.text = "";
		dead.text = "";
		water = false;
		wtfound = false;
		audioData = GetComponent<AudioSource>();
		food_script = GameObject.Find("Food").GetComponent<food>();
		interact.text = "";
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
        dead.text = "This person has a water bottle next to them, but I don't know if they're dead or not... If I don't take it, I risk my sister's life. If I do take it, I risk his...";
        yield return new WaitForSecondsRealtime(10);
    
		dead.text = "I'm so sorry. If you're alive, I'm so sorry.";
		yield return new WaitForSecondsRealtime(6);
		dead.text = "";

		gameObject.SetActive(false);
		waterFound.text = "You found water.";
		water = true;
		wtfound = true;


		//if(Food.food.fdfound){

		//}

		if(food_script.fdfound) {
			SceneManager.LoadScene(2);
   	   	}		
	
	}
}
