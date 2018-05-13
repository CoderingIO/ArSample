using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
	public GameObject panel;
	private Animator animator;
	public Image panelImage;

	// Use this for initialization
	void Start () {
		animator = panel.GetComponent<Animator> ();

		if (PlayerPrefs.GetString ("preferredColor") == "green") {
			panelImage.color = new Color (0, 1, 0);
		} else if (PlayerPrefs.GetString ("preferredColor") == "blue") {
			panelImage.color = new Color (0, 0, 1);
		} else if (PlayerPrefs.GetString ("preferredColor") == "red") {
			panelImage.color = new Color (1, 0, 0);
		}
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

	public void SetColorBlue(){
		panelImage.color = new Color (0, 0, 1);
		PlayerPrefs.SetString ("preferredColor", "blue");
	}

	public void SetColorRed(){
		panelImage.color = new Color (1, 0, 0);
		PlayerPrefs.SetString ("preferredColor", "red");
	}

	public void SetColorGreen(){
		panelImage.color = new Color (0, 1, 0);
		PlayerPrefs.SetString ("preferredColor", "green");
	}
}
