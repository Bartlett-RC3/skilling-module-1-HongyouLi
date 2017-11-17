using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session_4 : MonoBehaviour {

    //Variable
    public GameObject columnPrefab;
    IEnumerator createColumnCoroutine;
    float p = -1;
    float j;
    // Use this for initialization
    void Start () {
        createColumnCoroutine = DropColumns();
        StartCoroutine(createColumnCoroutine);


    }
	
	// Update is called once per frame
	void Update () {
        //Destroy(columnPrefab, 1);
        Debug.Log(Time.time);
        if (Time.time > 20)
        {
            StopCoroutine(createColumnCoroutine);
            StopAllCoroutines();
        
        }
       

    }


    //Coroutines
    IEnumerator DropColumns() {

        while (true)
        {
            
            yield return new WaitForSeconds(1);
            Vector3 columnPosition = new Vector3(Random.Range(-4f, 4f), Random.Range(3f, 10f), Random.Range(-4f, 4f));
            Quaternion columnRotation = new Quaternion(Random.Range(0, 90), Random.Range(0, 90), Random.Range(0, 90), 1);
            //means rotation  x y z w(means 0-1)
            GameObject newColumn = Instantiate(columnPrefab, columnPosition, columnRotation);


            ////////add one clone per time
            p = p + 1;

            j = Mathf.Pow(2, p);

            for (int i = 0; i <= j - 1; i++)
            {
                Destroy(newColumn, 3);

            }
            ////////////////
        }
    }

}

