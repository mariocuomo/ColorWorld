using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreenManager : MonoBehaviour {
    public float timer;

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("musica", 1);

        timer = 5f;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer < 0)
            Application.LoadLevel("MainMenu");
	}
}
