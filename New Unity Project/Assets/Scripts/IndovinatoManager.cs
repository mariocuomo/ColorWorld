using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IndovinatoManager : MonoBehaviour {
    float timer;
    public Text puntini;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt("musica") == 1)
        {
            GameObject.Find("Ghost").GetComponent<AudioSource>().volume = 1;
        }
        timer += Time.deltaTime;

        if (timer <= 0.5)
            puntini.text = ".";
        if (timer >= 0.5 && timer <= 1)
            puntini.text = "..";
        if (timer >= 1 && timer <= 1.5)
            puntini.text = "...";
        if (timer >= 1.5 && timer <= 2)
            puntini.text = ".";
        if (timer >= 2 && timer <= 2.5)
            puntini.text = "..";
        if (timer >= 2.5 && timer <= 3)
            puntini.text = "...";
        if (timer >= 3 && timer <= 3.5)
            puntini.text = ".";
        if (timer >= 3.5 && timer <= 4)
            puntini.text = "...";
        if (timer >= 4)
            Application.LoadLevel("MainMenu");

    }
}
