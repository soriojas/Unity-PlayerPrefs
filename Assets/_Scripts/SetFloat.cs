//This script sets the float up in the PlayerPrefs to be used elsewhere. Use GetFloat to return the settings.
using UnityEngine;
using UnityEngine.UI;

public class SetFloat : MonoBehaviour
{
    public Text speedValueText;
    //public Scrollbar speedScroller;

    void Awake()
    {
        //Give the PlayerPrefs some values to send over
        PlayerPrefs.SetFloat("Speed", PlayerPrefs.GetFloat("Speed"));
    }

    void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            PlayerPrefs.SetFloat("Speed", PlayerPrefs.GetFloat("Speed") + 1);
        }

        if (Input.GetKeyDown("x"))
        {
            PlayerPrefs.SetFloat("Speed", PlayerPrefs.GetFloat("Speed") - 1);
        }

        //i was told to not use PlayerPrefs.Save() inside of Update(), but I'm not sure where else to use it.
        if (Input.GetKeyDown("c"))
        {
            PlayerPrefs.Save();
        }

        if (Input.GetKeyDown("r"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }

    }
}