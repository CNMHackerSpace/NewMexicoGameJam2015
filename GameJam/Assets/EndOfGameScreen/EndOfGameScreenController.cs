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
    }
   
    void OnEnable(){
        //Only read file one time
        if (lines == null)
        {
            GetDeaths();
        }
        SetResulText();
	}

    void GetDeaths()
    {
		TextAsset trajicDeaths = Resources.Load("TrajicDeaths") as TextAsset;
		lines = trajicDeaths.text.Split('\n');
	}

    void SetResulText()
    {
        //randomly select a line
        string death = lines[Random.Range(0, lines.Length-1)];

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
		//Reset score
		gc.Score = 0;
        this.gameObject.SetActive(false);
        gameScreen.gameObject.SetActive(true);
    }
}