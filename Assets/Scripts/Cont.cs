using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cont : MonoBehaviour {

	public void PlayGame(){
	    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
