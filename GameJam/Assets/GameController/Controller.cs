using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Text;
using System.IO;

public class Controller : MonoBehaviour {
    //using Text teextArea;
	// Use this for initialization
    public InputField sceneTexBox;
    public InputField actorsTexBox;
    public Button iAmBtn;
    public Button iAmNotBtn;
    public GameController gameController;
    private Actor[] actors;
    private Scene[] scenes;
    private int actorIndex;
    private int sceneIndex;
    public Canvas endOfGameScreen;

	void Start () {
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
        lines = System.IO.File.ReadAllLines(@"..\GameJam\Assets\GameController\Actors.txt");
       // sceneTexBox.text += lines.Length.ToString();
        actors = new Actor[lines.Length];
        for (int i = 0; i < lines.Length; ++i)
        {
           // sceneTexBox.text += lines[i];
            Actor actor = new Actor();
            actor.Name = lines[i];
            actors[i] = actor;

        }
        lines = System.IO.File.ReadAllLines(@"..\GameJam\Assets\GameController\Scenes.txt");
        scenes = new Scene[lines.Length];
        for (int i = 0; i < lines.Length; ++i)
        {
            string[] elements = lines[i].Split(',');
            Scene scene = new Scene();
            scene.ActorID =int.Parse((elements[0]));
            scene.Description = elements[1];
            scenes[i] = scene;
        
        }

    }

  

    private void RandSelectActorandScene()
    {
        actorIndex = Random.Range(0, actors.Length);
        sceneIndex = Random.Range(0, scenes.Length);
        sceneTexBox.text =  scenes[sceneIndex].Description;
        actorsTexBox.text = actors[actorIndex].Name;

    
    }
    public void buttonIam()
    {
        if (actorIndex == scenes[sceneIndex].ActorID)
        {
            gameController.Score += 10;
            RandSelectActorandScene();

        }
        else
        {
            this.gameObject.SetActive(false);
            endOfGameScreen.gameObject.SetActive(true);
        
        }

    }
    public void buttonIamNot()
    {
        if (actorIndex == scenes[sceneIndex].ActorID)
        {
            gameController.Score -= 1;
            RandSelectActorandScene();

        }
        else
        {
            gameController.Score += 1;
            RandSelectActorandScene();

        }

    }

    public void calcScore()//calc score will take the values from the buttons and 
    { 
    //How can I get the total values from the buttons?
    
    }


}
