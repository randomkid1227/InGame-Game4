using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l_poop : AbstractLevel
{
    float minX = -5.5f;
    float minY = -4.5f;
    float maxX = 5.5f;
    float maxY = 4.5f;
    public GameObject poop;
    public GameObject garbage;
    public int numberOfObjects;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void createObjects()
    {
        Instantiate(garbage);
        for (int i = 0; i < numberOfObjects; i++)
        {
            GameObject temp = Instantiate(poop);
            temp.transform.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        }


    }
}
