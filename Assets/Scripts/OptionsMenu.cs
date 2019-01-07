using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OptionsMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ResetData()
    {
        Debug.Log("Reset Data");
        PlayerPrefs.SetInt("CurrentLevel", 1); //Set to play the first level using scene index build number
    }
}
