using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

public class SpeechRecognitionEngine : MonoBehaviour
{
    public string[] keywords;
    public ConfidenceLevel confidence = ConfidenceLevel.Medium;

    protected PhraseRecognizer recognizer;
    protected string word = "right";

    public GameObject star;
    public int coloreDetto;
    public int coloreIniziale;

    private void Start()
    {
        coloreIniziale = Random.Range(0, 8);
        coloreDetto = -1;

        SelectColor();

        if (keywords != null)
        {
            recognizer = new KeywordRecognizer(keywords, confidence);
            recognizer.OnPhraseRecognized += Recognizer_OnPhraseRecognized;
            recognizer.Start();
        }
    }

    private void Recognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        word = args.text;
    }

    private void Update()
    {
        switch (word) { 
        case "red":
                { 
                coloreDetto = 0;
                }
                break;
            case "white":
                { 
                coloreDetto = 1;
        }
        break;
            case "blu":
                { 
                coloreDetto = 2;
        }
        break;
            case "blue":
                { 
                coloreDetto = 3;
        }
        break;
            case "green":
                { 
                coloreDetto = 4;
        }
        break;
            case "yellow":
                { 
                coloreDetto = 5;
        }
        break;
            case "purple":
                { 
                coloreDetto = 6;
        }
        break;
            case "black":
                { 
                coloreDetto = 7;
                }
                break;
        }

        if (coloreDetto == coloreIniziale)
            Application.LoadLevel("Indovinato");

    }

    private void OnApplicationQuit()
    {
        if (recognizer != null && recognizer.IsRunning)
        {
            recognizer.OnPhraseRecognized -= Recognizer_OnPhraseRecognized;
            recognizer.Stop();
        }
    }

    public void SelectColor()
    {

        switch (coloreIniziale)
        {
            case 0:
                star.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
                break;
            case 1:
                star.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                break;
            case 2:
                star.GetComponent<Image>().color = new Color32(0, 0, 255, 255);
                break;
            case 3:
                star.GetComponent<Image>().color = new Color32(0, 0, 255, 255);
                break;
            case 4:
                star.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                break;
            case 5:
                star.GetComponent<Image>().color = new Color32(255, 255, 0, 255);
                break;
            case 6:
                star.GetComponent<Image>().color = new Color32(255, 0, 255, 255);
                break;
            case 7:
                star.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
                break;
        }
    }

    public void Back()
    {
        if (PlayerPrefs.GetInt("musica") == 1)
        {
            GameObject.Find("Ghost").GetComponent<AudioSource>().volume = 1f;
        }
        Application.LoadLevel("MainMenu");
    }

    public void red()
    {
        coloreDetto = 0;
        if (coloreDetto == coloreIniziale)
            Application.LoadLevel("Indovinato");
    }
    public void white()
    {
        coloreDetto = 1;
        if (coloreDetto == coloreIniziale)
            Application.LoadLevel("Indovinato");
    }
    public void blu()
    {
        coloreDetto = 2;
    }
    public void blue()
    {
        coloreDetto = 3;
        if (coloreDetto == coloreIniziale)
            Application.LoadLevel("Indovinato");
    }
    public void green()
    {
        coloreDetto = 4;
        if (coloreDetto == coloreIniziale)
            Application.LoadLevel("Indovinato");
    }
    public void yellow()
    {
        coloreDetto = 5;
        if (coloreDetto == coloreIniziale)
            Application.LoadLevel("Indovinato");
    }
    public void purple()
    {
        coloreDetto = 6;
        if (coloreDetto == coloreIniziale)
            Application.LoadLevel("Indovinato");
    }
    public void black()
    {
        coloreDetto = 7;
        if (coloreDetto == coloreIniziale)
            Application.LoadLevel("Indovinato");
    }
}
