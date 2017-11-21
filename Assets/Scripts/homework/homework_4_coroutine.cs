using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homework_4_coroutine : MonoBehaviour {

    public GameObject CubeReceiver;


    IEnumerator createCubeCoroutine;


    IEnumerator DropCube()
    {

        while (true)
        {
            Vector3 cubePosition = new Vector3(Random.Range(-10f, 10f), Random.Range(0f, 20f), 0);
            Quaternion cubeRotation = new Quaternion(0,0,0,1);
            //means rotation  x y z w(means 0-1)
            GameObject newCube = Instantiate(CubeReceiver, cubePosition, cubeRotation);
            yield return new WaitForSeconds(1f);
        }

    }
    // Use this for initialization
    void Start () {
        createCubeCoroutine = DropCube();
        StartCoroutine(createCubeCoroutine);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
