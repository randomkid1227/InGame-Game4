using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionTap : MonoBehaviour {
    
    public int Levels;
    private int[] DontLoad;
    private int[] Load;

	private void Start()
	{
        DontLoad = GlobalControl.Instance.DontLoad;
        DontLoad = GlobalControl.Instance.Load;
	}

	// Update is called once per frame
	void Update () {
        LoadByTap();
	}

    void LoadByTap () {
        if (Input.touchCount > 0) {
            LoadByIndex(NextLevel());
        }
    }

    public void LoadByIndex(int sceneIndex) {
        SceneManager.LoadScene(sceneIndex);
    }


    int NextLevel() {

        int random = (int)Mathf.Floor(Random.Range(0, Load.Length));
        int chosen = Load[random];

        Swap(random);

        return chosen;
    }


    void Swap(int level) {
        int temp = Load[level];
        int swap = DontLoad[1];

        Load[level] = swap;
        DontLoad[1] = DontLoad[0];
        DontLoad[0] = temp;
    }

}
