using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Text;
using System.IO;

public class PlayController : MonoBehaviour {
    //using Text teextArea;
	// Use this for initialization
    public InputField sceneTexBox;
    public InputField actorsTexBox;
    public Button iAmBtn;
    public Button iAmNotBtn;
    public GameController gameController;
	public Text txtScore;
    private Actor[] actors;
    private Scene[] scenes;
    private int actorIndex;
    private int sceneIndex;
    public Canvas endOfGameScreen;

	void Start () 
	{
        ReadFiles();
        RandSelectActorandScene();     
	}
	

	// Update is called once per frame
	void Update () {
	
	}
    
    public void ReadFiles()
    {
        sceneTexBox.text = "clicked";
        string[] lines;

       // int counter = 0;
        //string line;
        //lines = System.IO.File.ReadAllLines(@"..\GameJam\Assets\PlayScreen\Actors.txt");
		TextAsset actorsText = Resources.Load("Actors") as TextAsset;
		lines = actorsText.text.Split('\n');
		actors = new Actor[lines.Length];

        for (int i = 0; i < lines.Length; ++i)
        {
           // sceneTexBox.text += lines[i];
            Actor actor = new Actor();
            actor.Name = lines[i];
            actors[i] = actor;

        }
		//lines = System.IO.File.ReadAllLines(@"..\GameJam\Assets\PlayScreen\Scenes.txt");
		TextAsset sceneText = Resources.Load("Scenes") as TextAsset;
		lines = sceneText.text.Split('\n');
		scenes = new Scene[lines.Length];
        for (int i = 0; i < lines.Length; ++i)
        {
            string[] elements = lines[i].Split('|');
            Scene scene = new Scene();
            scene.ActorID =int.Parse((elements[0]));
            scene.Description = elements[1];
            scenes[i] = scene;
        }
    }  

    private void RandSelectActorandScene()
    {

        sceneIndex = Random.Range(0, scenes.Length-1);
        sceneTexBox.text =  scenes[sceneIndex].Description;
		if(Random.Range(0,2)==0)
		{
			//Make actor actor in scene
			actorIndex = scenes[sceneIndex].ActorID;
		}
		else
		{
			//Make actor a random actor
			actorIndex = Random.Range(0, actors.Length-1);
		}
        actorsTexBox.text = actors[actorIndex].Name;    
    }
    public void buttonIam()
    {
        if (actorIndex == scenes[sceneIndex].ActorID)
        {
            gameController.Score += 5;
            RandSelectActorandScene();

        }
        else
        {
            this.gameObject.SetActive(false);
            endOfGameScreen.gameObject.SetActive(true);        
        }
		DisplayScore();
    }
    public void buttonIamNot()
    {
        if (actorIndex == scenes[sceneIndex].ActorID)
        {
            gameController.Score -= 5;
            RandSelectActorandScene();

        }
        else
        {
            gameController.Score += 1;
            RandSelectActorandScene();
        }
		DisplayScore();
	}

    public void DisplayScore()
    { 
    	txtScore.text = "Score: "+gameController.Score.ToString();    
    }


}
