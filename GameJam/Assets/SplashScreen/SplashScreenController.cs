using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class SplashScreenController : MonoBehaviour {

    public Canvas gameScreen;
    public Text status;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void StartGame()
    {
        this.gameObject.SetActive(false);
        gameScreen.gameObject.SetActive(true);
        status.text = "Clicked!";
    }

}
