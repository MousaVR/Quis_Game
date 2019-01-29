using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour {

    public RoundData [] roundData;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);

        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuScene");
	}

    public RoundData GetCurrentRoundata()
    {
        return roundData[0];
    }
	
}
