using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session_3 : MonoBehaviour {

    //Variables
    int counter = 0;
    public GameObject CubeReference;
    bool moveLeft = true;
    bool moveRight = false;



	// Use this for initialization
	void Start () {
      /*  for (int i=0;i<100;i++) {
            Vector3 CubePosition = new Vector3(i+0.5f,0,0);
            Quaternion CubeRotation = Quaternion.identity;///????
            GameObject newCube = Instantiate(CubeReference,CubePosition,CubeRotation);
        }
        */
	}

    // Update is called once per frame
    void Update() {

        //Time in frame is not useful because of variation
        /* counter = counter + 1;
         if (counter%30 ==00) { ///orignial frame=30
             Debug.Log("Time in frames is: " + counter/30);//////==frameRate
         }
         //time is millisenconds, useful because it is precise.
         Debug.Log("Actual time is: " + Time.deltaTime.ToString());
         */

        //Move cube left and right
        /*
        if (moveLeft == true) {
            if (counter <= 15)
            {////session__object_component_position
                this.gameObject.GetComponent<Transform>().position = new Vector3(counter * (-1), 0, 0);
                counter++;

            }
            else {
                moveLeft = false;
                moveRight = true;
                counter = 0;
            }
        }
        if (moveRight == true)
        {
            if (counter <= 15)
            {////session__object_component_position
                this.gameObject.GetComponent<Transform>().position = new Vector3(counter, 0, 0);
                counter++;
            }
            else
            {
                moveLeft = true;
                moveRight = false;
                counter = 0;
            }

        }*/
        ///////manually new component
        if (moveLeft == true)
        {
            if (counter <= 15)
            {////session__object_component_position
               // gameObject.transform.Translate(Vector3.left); 
                counter++;

            }
            else
            {
                moveLeft = false;
                moveRight = true;
                counter = 0;
            }
        }
        if (moveRight == true)
        {
            if (counter <= 15)
            {////session__object_component_position
               // gameObject.transform.Translate(Vector3.right);
                counter++;
            }
            else
            {
                moveLeft = true;
                moveRight = false;
                counter = 0;
            }

        }
        //keyboard input
        if(Input.GetKey(KeyCode.Space)){   ///getkey is hold  down&up 
            gameObject.transform.Rotate(new Vector3(0,5,0));

         }
        if (Input.GetMouseButton(0))  ///mouseButton 0left 1right 2middle
        {   ///getkey is hold  down&up 
            gameObject.transform.localScale = new Vector3(0.5f,0.5f, 0.5f);///f=float because 0.5
        }
        if (Input.GetMouseButton(01))  ///mouseButton 0left 1right 2middle
        {   ///getkey is hold  down&up 
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }

    }
}
