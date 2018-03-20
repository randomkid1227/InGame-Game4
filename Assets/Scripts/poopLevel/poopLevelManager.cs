using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poopLevelManager : MonoBehaviour {
    public GameObject garbage;
    public GameObject poop;
    float startTime;
    float endTime;
    float minX = -5.5f;
    float minY = -4.5f;
    float maxX = 5.5f;
    float maxY = 4.5f;
    public int numberOfItems;


	// Use this for initialization
	void Start () {
        numberOfItems = (int)Random.Range(3f, 5f);
        Debug.Log(numberOfItems);
        startTime = Time.time;
        endTime = startTime + 5; //Manager.gameObject.levelTime; //TODO: create leveltime in Manager or something...
        for (int i = 0; i < numberOfItems; i++) Invoke("spawnObjects", 0.05f);
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time >= endTime)
        {
            int x = 1; //TODO: Enter logic to see if won
        }
        if (numberOfItems <= 0)
        {
            Debug.Log("WON"); //Win condition
        }
		
	}
 
    void spawnObjects()
    {
        GameObject poopInstance = Instantiate(poop);
        poopInstance.transform.position = new Vector3( Random.Range(minX, maxX), Random.Range(minY, maxY) );
        Debug.Log("...");
        
    }
}
