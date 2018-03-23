using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningScene : MonoBehaviour {

    public int HP;
    public float Time;
    public int Score;
    public int Levels;
    public int Screens;

	// Use this for initialization
	void Start () {
        GlobalControl.Instance.HP = HP;
        GlobalControl.Instance.Score = Score;
        GlobalControl.Instance.Levels = Levels;
	}

	private void Awake()
	{
        // Initialize the DontLoad Array
        int[] DontLoadArr = GlobalControl.Instance.DontLoad;
        DontLoadArr = new int[2];
        DontLoadArr[0] = 0; 
        DontLoadArr[1] = 2;

        // Intilialize the Load Array
        int[] LoadArr = GlobalControl.Instance.Load;
        LoadArr = new int[Levels - 2];
        int x = Levels + Screens;
        for (int i = Screens; i < (x - 2); i++) {
            if (i != 0 && i != 2) {
                LoadArr[i - Screens] = i;
            }
        }
	}
}
