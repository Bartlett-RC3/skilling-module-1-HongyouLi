//References
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//where code lives
public class Session_1 : MonoBehaviour {
    //1.Variables
    //Scope -- Type--Name--Value

    //Numbers
    public int myFirstIntegerNumber = 98;
    float myFirstFloatNumber = 1.7f;


    // Text 
    public string myFirstString = "My text is somewhere";
    //logical variable
    bool myFirstBoolean = true; //or false



    //Data stuctures
    //Scope--Type--Values
    //3.a.Arrays   
   // public int[] myintegerArray = { 1,2,3,4,5};
    public float[] myFloatArray = new float[9];

    //3.b.Lists   
    public List<int> myIntegerList = new List<int>();
    //4.Dictionaries                               
    //2.Functions

    //Scope--Type--Variables--Body(instuctions)


    // Use this for initialization
    void Start () {
        Debug.Log("Addition Of 5 and 3 is:" + AdditionOfNumbers(5, 3));
        //FrameRate();
        myFloatArray[2] = 3.2f;
        myFloatArray[3] = 5.6f;
        //myFloatArray[9] = 9.2f;  mistake --empty
        myIntegerList.Add(1);
        myIntegerList.Add(2);
        myIntegerList.Add(3);
        //myIntegerList.Remove(0);
    }
   
	// Update is called once per frame
	void Update () {
        //Debug.Log("Hello world!!");
		
	}
    int AdditionOfNumbers(int number1, int number2)
    {
        int additionResult = number1 + number2;
        return additionResult;

    }
}
