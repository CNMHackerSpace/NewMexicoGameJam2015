using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Text;
using System.IO;

public class Controller : MonoBehaviour {
    //using Text teextArea;
	// Use this for initialization
    public InputField stb;
    public InputField atb;
    public Button iAmBtn;
    public Button iAmNotBtn;

	void Start () {
	//TextAreaAttribute.text = "";
      /*  string[] lines = System.IO.FileShare.ReadAllLines("Scenes.text");
        Scene[] scenes = new Scene[lines.Length];
        for(int i = 0; i < lines.Length; i++)
        {
            Scene scene = new Scene();
            scene.ActorID = 1;
            scene.Description ="test";
         //   scene.ActorId2 = 2;
            scenes[i] = scene;
        */
     
	}
	

	// Update is called once per frame
	void Update () {
	
	}
    
    public void ActorFile()//We want to read the file and put it into a list
    {
        string filePath; //= Scenes.text;
        int counter = 0;
        string line;
      
        string[] arrScenes = Directory.GetFiles("Scenes.txt");
        string[] arrAct = Directory.GetFiles("Actors.txt");
        Random r = new Random();
        int randomIndex = 0;

       /// while{arrAct.Count > 0)
      //  {

     //   }
       // List<string>    

    }

    public void buttonIam()
    {
        bool t = true;//T will equal true 
        bool f = false;//f will equal false
        int addOne;
        int subtractOne;
        if (t)
        {
            addOne = 1;
        }
        else
        {
            subtractOne = -1;
        
        }

    }

    public void buttonIamNot()
    {
        bool t = true;//T will equal true 
        bool f = false;//f will equal false
        int addOne;
        int subtractOne;
        if (t)
        {
            addOne = 1;
        }
        else
        {
            subtractOne = -1;

        }
    }

    public void calcScore()//calc score will take the values from the buttons and 
    { 
    //How can I get the total values from the buttons?
    
    }


}
