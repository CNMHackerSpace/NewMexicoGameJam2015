using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndOfGameScreenController : MonoBehaviour {

    public GameController gc;
    public Text txtScore;
    public Canvas gameScreen;
    string[] lines;

	// Use this for initialization
    void Start() {
        //read in text file
        lines = System.IO.File.ReadAllLines(@"..\GameJam\Assets\EndOfGameScreen\TrajicDeaths.txt");
        SetResulText();
    }
   
    void OnEnable(){
        SetResulText();
	}

    void SetResulText()
    {
        //randomly select a line
        string death = lines[Random.Range(0, lines.Length)];

        //display results
        txtScore.text =
                "You die a tragic death!\n\n"
                + "You are " + death + "\n\n"
                + "Your score: " + gc.Score;
    }
    // Update is called once per frame
    void Update()
    {
	
	}

    public void PlayAgain()
    {
        this.gameObject.SetActive(false);
        gameScreen.gameObject.SetActive(true);
    }
}