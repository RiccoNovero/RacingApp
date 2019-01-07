using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public int currentLevel;
	// Use this for initialization
	void Start () {
		currentLevel = PlayerPrefs.GetInt("CurrentLevel", 0);
        if (currentLevel == 0)
        {
            currentLevel = 1;
            PlayerPrefs.SetInt("CurrentLevel", currentLevel);
        }
        Debug.Log("currentLevel = " + currentLevel);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayGame()
    {
        currentLevel = PlayerPrefs.GetInt("CurrentLevel", 1);
        Debug.Log("CurrentLevel = " + currentLevel);
        SceneManager.LoadScene(currentLevel);
        Debug.Log("Load Scene " + currentLevel);
    }

    public void QuitGame()
    {
        Debug.Log("Game quits");
        Application.Quit();
    }
}
