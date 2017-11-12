//Session_2: Conditionals, Loops nad Classes
//UCL RC3 12NOV 2017

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session_2 : MonoBehaviour {

    public int myNumber = 2;
    bool questionTime = false;
    int myVariableQuestionTime;

	// Use this for initialization
	void Start () {
        //Variable name is equal to either 1 or 0 based on the valuse of questionTime
        myVariableQuestionTime = (questionTime ==true) ? 1 : 0;
        Debug.Log("The Value of myVariableQuestionTime is: " + myVariableQuestionTime);
        
	}
	
	// Update is called once per frame
	void Update () {
        //Conditionals
        /*
        if (myNumber == 2)
        {
            Debug.Log("Your number is equal to 2.");
        }
        else
        {
            Debug.Log("Your number is not equal to 2.");
        }
        */
        if (questionTime) {
            Debug.Log("Question time is false.");
        }
        else
        {
            Debug.Log("Question time is true.");
        }
        
    }
}
