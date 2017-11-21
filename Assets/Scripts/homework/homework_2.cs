using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homework_2 : MonoBehaviour {


    //Write a function that uses a condition
    public int catNumber = 1;
    public bool YouLoveCat = true;
    int myVariableQuestionTime;

    string[] animals = { "Panda", "Ant", "Fish", "Bird" };
    List<int> catList= new List<int> ();
    int[] catListOrder= new int[10];

    List<dog> RC3_pet = new List<dog>();


	// Use this for initialization
	void Start () {
        //Write a function that uses a condition
		if (catNumber == 1 && YouLoveCat == true)
        {
            Debug.Log("You have a cat");
        }

        if (catNumber == 2 && YouLoveCat == true)
        {
            Debug.Log("You are so happy");
        }
        if (catNumber == 0 || YouLoveCat == false)
        {
            Debug.Log("why don't you like a cat? ");
        }
       

        //Write a for loop
        for (int i = 0;i<animals.Length; i++) {
            Debug.Log("Animal at position "+(i+1)+" is "+animals[i]);
        }
        for (int i=0; i<20;i=i+2) {
            catList.Add(i);
            catListOrder[i / 2] = i;
        }
        for (int i=0;i< catList.Count;i++) {
            Debug.Log("The number of cats is " + catList[i]);
          
        }
        //Write a dog class and initialize an instance of the class
        dog Lucy = new dog(2,8f,true,"Lucy",true,100f,"yellow");//int _age, float _weight, bool _gender, string _name, hungery, float _energy, string _color
        dog Max = new dog(4,10f,false,"Max",true,100f,"grey");
        dog Rocky = new dog(5,12f,true,"Rocky",false,100f,"gold");
        dog Buddy = new dog(8,15f,true,"Buddy",true,100f,"brown");
        RC3_pet.Add(Lucy);
        RC3_pet.Add(Max);
        RC3_pet.Add(Rocky);
        RC3_pet.Add(Buddy);



    }
	
	// Update is called once per frame
	void Update () {
        for (int i =0;i<RC3_pet.Count;i++) {
            Debug.Log(RC3_pet[i].GetDogName()+" is one of pets of RC3");
        }
	}
}
