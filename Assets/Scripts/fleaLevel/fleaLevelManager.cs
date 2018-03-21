using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fleaLevelManager : MonoBehaviour
{

    public GameObject flea;
    float startTime;
    float endTime;
    float remainingLevelTime;
    float minX = -5.5f;
    float minY = -4.5f;
    float maxX = 5.5f;
    float maxY = 4.5f;
    public int numberOfItems;
    public int itemCounter;
    private int lastSpawned;

    // Use this for initialization
    void Start()
    {
        itemCounter = 0;
        lastSpawned = 0;
        numberOfItems = (int)Random.Range(3f, 5f);
        Debug.Log(numberOfItems);
        startTime = Time.time;
        endTime = startTime + Time.t; //Manager.gameObject.levelTime; //TODO: create leveltime in Manager or something...
        
    }

    // Update is called once per frame
    void Update()
    {
        updateRemainingLevelTime();
        if (Time.time - lastSpawned > 1 && remainingLevelTime > 0.5f && itemCounter < numberOfItems)
        {
            spawnObject();
            itemCounter++;
        }
        if (Time.time >= endTime)
        {
            LoadByIndex(2); // Lose screen  
        }
        if (numberOfItems <= 0)
        {
            LoadByIndex(1); // Win screen
        }
        else if (remainingLevelTime <= 0) Debug.Log("LOST");
    }

    void updateRemainingLevelTime()
    {
        this.remainingLevelTime = this.endTime - Time.time;
    }

    void spawnObject()
    {
        GameObject fleaInstance = Instantiate(flea);
        fleaInstance.transform.position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY));
        Debug.Log("...");

    }
    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
