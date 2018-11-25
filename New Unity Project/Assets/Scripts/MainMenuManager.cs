using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Stellas()
    {
        if (PlayerPrefs.GetInt("musica") == 1)
        {
            GameObject.Find("Ghost").GetComponent<AudioSource>().volume = 0.05f;
        }
        Application.LoadLevel("Indovina");
    }

    public void Conos()
    {
        if (PlayerPrefs.GetInt("musica") == 1)
        {
            GameObject.Find("Ghost").GetComponent<AudioSource>().volume = 0.05f;
        }
        Application.LoadLevel("Colora");
    }

    public void Settings()
    {
        Application.LoadLevel("Settings");

    }

    public void Share()
    {
        Application.OpenURL("fb://page/2067150670198337 /");
        Application.OpenURL("https://www.facebook.com/LittleItaly-Team-2067150670198337");

    }
}
