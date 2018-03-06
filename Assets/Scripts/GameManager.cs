using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public float levelTime;
    public int score;
    public float startTime;

    public GameObject[] levels;

	// Use this for initialization
	void Start () {
        this.levelTime = 5;
        this.score = 0;
        this.startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time - this.startTime > levelTime)
        {
            endCurrentLevel();
        }
		
	}

    void endCurrentLevel()
    {
        return;
    }

    //LEVELS ARE SCENES

    void StartNewLevel()
    {
        return;
    }
}
