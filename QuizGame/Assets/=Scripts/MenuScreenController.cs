using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScreenController : MonoBehaviour {

    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
}
