using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

public class ColoraManager : MonoBehaviour {
    public GameObject cono;
    public GameObject palla1;
    public GameObject palla2;
    public GameObject palla3;
    public int scelto;

    public string[] keywords;
    public ConfidenceLevel confidence = ConfidenceLevel.Medium;

    protected PhraseRecognizer recognizer;
    protected string word = "right";

    GameObject star;

    // Use this for initialization
    void Start () {
        scelto = -1;

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

    // Update is called once per frame
    void Update () {
            switch (word)
            {
                case "red":
                    {
                        star.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
                        word = "";
                    }
                    break;
                case "white":
                    {
                        star.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                    word = "";

                }
                break;
                case "blu":
                    {
                        star.GetComponent<Image>().color = new Color32(0, 0, 255, 255);
                    word = "";

                }
                break;
                case "blue":
                    {
                        star.GetComponent<Image>().color = new Color32(0, 0, 255, 255);
                    word = "";

                }
                break;
                case "green":
                    {
                        star.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
                    word = "";

                }
                break;
                case "yellow":
                    {
                        star.GetComponent<Image>().color = new Color32(255, 255, 0, 255);
                    word = "";

                }
                break;
                case "purple":
                    {
                        star.GetComponent<Image>().color = new Color32(255, 0, 255, 255);
                    word = "";

                }
                break;
                case "black":
                    {
                        star.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
                    word = "";

                }
                break;
            }
        }

    public void clickcono()
    {
        cono.GetComponent<Outline>().effectDistance = new Vector2(3, 3);
        palla1.GetComponent<Outline>().effectDistance = new Vector2(2, 2);
        palla2.GetComponent<Outline>().effectDistance = new Vector2(2, 2);
        palla3.GetComponent<Outline>().effectDistance = new Vector2(2, 2);
        scelto = 0;
        star = cono;
    }

    public void clickpalla1()
    {
        cono.GetComponent<Outline>().effectDistance = new Vector2(0, 0);
        palla1.GetComponent<Outline>().effectDistance = new Vector2(5, 5);
        palla2.GetComponent<Outline>().effectDistance = new Vector2(2, 2);
        palla3.GetComponent<Outline>().effectDistance = new Vector2(2, 2);
        scelto = 1;
        star = palla1;

    }

    public void clickpalla2()
    {
        cono.GetComponent<Outline>().effectDistance = new Vector2(0, 0);
        palla2.GetComponent<Outline>().effectDistance = new Vector2(5, 5);
        palla1.GetComponent<Outline>().effectDistance = new Vector2(2, 2);
        palla3.GetComponent<Outline>().effectDistance = new Vector2(2, 2);
        scelto = 2;

        star = palla2;
    }

    public void clickpalla3()
    {
        cono.GetComponent<Outline>().effectDistance = new Vector2(0, 0);
        palla3.GetComponent<Outline>().effectDistance = new Vector2(5, 5);
        palla2.GetComponent<Outline>().effectDistance = new Vector2(2, 2);
        palla1.GetComponent<Outline>().effectDistance = new Vector2(2, 2);
        scelto = 3;

        star = palla3;
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
        star.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        word = "";
    }
    public void white()
    {
        star.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        word = "";
    }
    public void blu()
    {
        star.GetComponent<Image>().color = new Color32(0, 0, 255, 255);
        word = "";
    }
    public void blue()
    {
        star.GetComponent<Image>().color = new Color32(0, 0, 255, 255);
        word = "";
    }
    public void green()
    {
        star.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
        word = "";
    }
    public void yellow()
    {
        star.GetComponent<Image>().color = new Color32(255, 255, 0, 255);
        word = "";
    }
    public void purple()
    {
        star.GetComponent<Image>().color = new Color32(255, 0, 255, 255);
        word = "";
    }
    public void black()
    {
        star.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        word = "";
    }
}
