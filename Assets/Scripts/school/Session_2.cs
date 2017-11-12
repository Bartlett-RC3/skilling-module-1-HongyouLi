//Session_2: Conditionals, Loops nad Classes
//UCL RC3 12NOV 2017

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session_2 : MonoBehaviour {

    public int myNumber = 2;
    public bool questionTime = true;
    int myVariableQuestionTime;

    string[] fruits = { "banana", "apple", "mango", "blueberry" };
    List<int> evenNumbers = new List<int> ();
    int[] evenNumbersSmart = new int[10];

	// Use this for initialization
	void Start () {
        //Variable name is equal to either 1 or 0 based on the valuse of questionTime
        //Conditionals
        /* */ //ignore what between these

        /*if (myNumber == 2)
        {
            Debug.Log("Your number is equal to 2.");
        }
        else
        {
            Debug.Log("Your number is not equal to 2.");
        }
        
        if (questionTime) {
            Debug.Log("Question time is false.");
        }
        else
        {
            Debug.Log("Question time is true.");
        }
        */
        myVariableQuestionTime = (questionTime == true) ? 1 : 0;
        Debug.Log("The Value of myVariableQuestionTime is: " + myVariableQuestionTime);
        //Question concatenation
        if (myNumber == 2 && questionTime == false)
        {
            Debug.Log("Your number is 2 and QT is false");
        }
        //Question or statement
        if (myNumber == 2 || questionTime == false)
        {
            Debug.Log("It may be that your number is 2 or it may be your QT is false");
        }

        //Loops
        //for loop statement (string value, how this ends,incrementation)
        Debug.Log("Fruit in list at position 1 is: " + fruits[0]);
        Debug.Log("Fruit in list at position 2 is: " + fruits[2]);
        for (int i = 0;i<fruits.Length; i++) {
            Debug.Log("Fruit at position "+i+" is "+fruits[i]);
        }
        for (int i=0; i<20;i=i+2) {
            evenNumbers.Add(i);
            evenNumbersSmart[i / 2] = i;
        }
        for (int i=0;i<evenNumbers.Count;i++) {
            Debug.Log("Number is "+evenNumbers[i]);
          
        }
        ////Add 100 numbers to list and print the numbers that are divisible by 5
        List<int> myOneHundredNumbers = new List<int>();

        for (int i=0; i<=100;i++) {
            myOneHundredNumbers.Add(i);

        }
        for (int i = 0; i <= myOneHundredNumbers.Count; i=i+5)
        {
            Debug.Log("Numbers divisible by 5: "+myOneHundredNumbers[i]);
        }
        //less smart way
        /*
        for (int i = 0; i <= 100; i++)
        {
            if (i % 5 == 0) {
                Debug.Log("Numbers divisible by 5: " + myOneHundredNumbers[i]);
            }
        }
        */
        //While loop
        List<int> oddNumbers = new List<int>();
        int counter = 1;
        while (counter < 100) {
            oddNumbers.Add(counter);
            counter = counter + 2;
        }
        for (int i =0;i<oddNumbers.Count;i++) {
            Debug.Log("Odd Number :"+oddNumbers[i]);

        }

    }
	
	// Update is called once per frame
	void Update () {
       
    }
}
