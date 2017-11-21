using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homework_3 : MonoBehaviour {
    //    Create a cube and move it across the screen

    int count = 0;
    public GameObject Cube;
    bool moveLeft = true;
    bool moveRight = false;
    float x = 0.1f;




    // Material cubeMaterial;
    Renderer cubeRenderer;



    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (moveLeft == true)
        {
            if (count >= -15)
            {
                gameObject.transform.Translate(Vector3.left);
                count--;

            }
            else
            {
                moveLeft = false;
                moveRight = true;
                count = -15;
            }
        }
        if (moveRight == true)
        {
            if (count <= 15)
            {
                gameObject.transform.Translate(Vector3.right);
                count++;
            }
            else
            {
                moveLeft = true;
                moveRight = false;
                count = 15;
            }
        }
        //Create a cube and change its colour when key is pressed or mouse is pressed
        

        Color cubeColor = Color.Lerp(Color.yellow, Color.blue, x);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cubeRenderer = GetComponent<Renderer>();
            cubeRenderer.material.color = cubeColor;

        }
       

        if (Input.GetMouseButton(0)) {
            x = x -0.1f;
            if (x<=0) {
                x = 0;
            }
            Debug.Log(x);

        }
        if (Input.GetMouseButton(1))
        {
            x = x +0.1f;
            if (x >= 1f)
            {
                x = 1f;
            }
            Debug.Log(x);
        }



    }
}
