using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homework_4 : MonoBehaviour {


   public GameObject CubeCaster;
    

    

    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        //Ray direction
        Vector3 castedRayDirection = CubeCaster.transform.TransformDirection(Vector3.forward);

        //Store the object that is in front 
        RaycastHit objectInFront;
        //Ray casting
        if (Physics.Raycast(CubeCaster.transform.position,castedRayDirection,out objectInFront)) {

            string objectInFrontName = objectInFront.transform.name;
            Debug.Log("There is an object in front of me! It's name is ："+ objectInFrontName);
            Destroy(objectInFront.transform.gameObject);
        }

        if (Input.GetKey(KeyCode.A)) {
            CubeCaster.transform.Translate(Vector3.left*0.5f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            CubeCaster.transform.Translate(Vector3.right*0.5f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            CubeCaster.transform.Translate(Vector3.up * 0.5f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            CubeCaster.transform.Translate(Vector3.down * 0.5f);
        }
    }

   
}
