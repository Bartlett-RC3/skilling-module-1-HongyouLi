using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session_4 : MonoBehaviour {

    //Variable
    public GameObject columnPrefab;
    IEnumerator createColumnCoroutine;

	// Use this for initialization
	void Start () {
        createColumnCoroutine = DropColumns();
        StartCoroutine(createColumnCoroutine);

    }
	
	// Update is called once per frame
	void Update () {
      
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {   ///getkey is hold  down up 
            StopCoroutine(createColumnCoroutine);

        }*/
    }


    //Coroutines
    IEnumerator DropColumns() {

        while (true) {
            yield return new WaitForSeconds(3);
            Vector3 columnPosition = new Vector3(Random.Range(-4f, 4f), Random.Range(3f, 10f), Random.Range(-4f, 4f));
            Quaternion columnRotation = new Quaternion(Random.Range(0, 90), Random.Range(0, 90), Random.Range(0, 90), 1);
            //means rotation  x y z w(means 0-1)
            GameObject newColumn = Instantiate(columnPrefab, columnPosition, columnRotation);
        }
    }
}

