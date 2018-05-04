using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
	public Animator panel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartGame(){
		SceneManager.LoadScene ("UDT");
	}

	public void QuitGame(){
		Application.Quit ();
	}

	public void RaisePanel(){
		panel.SetBool("panelUp", true);
	}

	public void LowerPanel(){
		panel.SetBool("panelUp", false);
	}
}
