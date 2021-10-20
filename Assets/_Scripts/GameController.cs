using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text timerText;

    int t = 0;

	void Update () {
        t += 1;
        timerText.text = "" + t;
	}
}
