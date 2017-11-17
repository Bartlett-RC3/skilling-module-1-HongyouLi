using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homework_1 : MonoBehaviour {
    //Declare a int variable and set a value
    public int Panda = 1;
    int Ant = 2;
    // Declare a float variable and set a value
    public float Bird = 0.1f;
    float Fish = 0.5f;
    //Declare a string variable and set a value
    
    string[] animals = { "Panda", "Ant", "Fish", "Bird" };

    //Declare and initialize an array
    public float[] animalArray = new float[4];
    //Declare and initialize a list
    public List<int> animalList = new List<int>(4);
    //Create and initialize a Dictionary
    public Dictionary<string, string> animalDictionary=new Dictionary<string, string>();
    
    
    void Start () {
        //Create a function that prints the declared variables
         Debug.Log("Panda lives in china"+ animals[1] + animals[2] + animals[3] + animals[4]);
       
    }


    void Update () {
		
	}
}
