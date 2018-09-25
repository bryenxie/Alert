using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hostpialScript : MonoBehaviour {

	public Text hospital;
	// Use this for initialization
	void Start () {
		hospital.text = "";
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
        hospital.text = "Oh God.... The Hospital... That was the explosion.. Who would do this? First the school, and now the Hospital.. What will I tell my sister?";
        yield return new WaitForSecondsRealtime(7);

         hospital.text = "";
        print(Time.time);
    }
}
