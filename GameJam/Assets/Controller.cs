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
	void Start () {
	//TextAreaAttribute.text = "";
     
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
       // if()//)
       // {
        
     // /  
     //   }



    }

    public void buttonIamNot()
    { 
    
    
    
    }

    public void calcScore()
    { 
    
    
    }


}
