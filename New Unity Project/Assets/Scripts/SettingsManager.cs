using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetInt("musica") == 0)
            GameObject.Find("ButtonMusic").GetComponent<Image>().color = new Color32(255, 10, 0, 255);

        if (PlayerPrefs.GetInt("musica") == 1)
            GameObject.Find("ButtonMusic").GetComponent<Image>().color = new Color32(0, 255, 35, 255);
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CambiaMusica()
    {
        if (PlayerPrefs.GetInt("musica") == 0)
        {
            PlayerPrefs.SetInt("musica", 1);
            GameObject.Find("ButtonMusic").GetComponent<Image>().color = new Color32(0, 255, 35, 255);
            GameObject.Find("Ghost").GetComponent<AudioSource>().volume = 1;

        }

        else
        {
            PlayerPrefs.SetInt("musica", 0);
            GameObject.Find("ButtonMusic").GetComponent<Image>().color = new Color32(255, 10, 0, 255);
            GameObject.Find("Ghost").GetComponent<AudioSource>().volume = 0;

        }

    }

    public void Back()
    {
        Application.LoadLevel("MainMenu");
    }
}
