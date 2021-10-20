//Use this script to fetch the PlayerPrefs settings and show them as text on the screen.
using UnityEngine;
using UnityEngine.UI;

public class GetFloat : MonoBehaviour
{
    float m_Speed;

    public GameObject character;
    public Text speedValueText;
    public Scrollbar speedScroller;

    void Start()
    {
        //Fetch the PlayerPref settings
        SetText();
    }

    void SetText()
    {
        //Fetch the Speed from the PlayerPrefs (set these Playerprefs elsewhere). If no float of this name exists, the default is 0
        m_Speed = PlayerPrefs.GetFloat("Speed");
        speedValueText.text = "" + m_Speed;
    }
    
    void Update()
    {
        SetText();
    }
}