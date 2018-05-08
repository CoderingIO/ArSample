using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
	public GameObject panel;
	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = panel.GetComponent<Animator> ();
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
		animator.SetTrigger ("playPanelSlide");
	}

	public void LowerPanel(){
		animator.SetTrigger ("resetPanelSlide");
	}
}
