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

        Debug.Log(Time.time);
        //if (Time.time > 25)
        //{
        //    StopCoroutine(createColumnCoroutine);
        //    StopAllCoroutines();

        //}


    }


    //Coroutines
    IEnumerator DropColumns() {

        while (true)
        {
            
            yield return new WaitForSeconds(0.1f);
            Vector3 columnPosition = new Vector3(Random.Range(-4f, 4f), Random.Range(15f, 20f), Random.Range(-4f, 4f));
            Quaternion columnRotation = new Quaternion(Random.Range(0, 90), Random.Range(0, 90), Random.Range(0, 90), 1);
            //means rotation  x y z w(means 0-1)
            GameObject newColumn = Instantiate(columnPrefab, columnPosition, columnRotation);
            Destroy(newColumn, 20);
        }
      
    }

}

