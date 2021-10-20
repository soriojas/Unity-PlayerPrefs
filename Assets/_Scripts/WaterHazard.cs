using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterHazard : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.gameObject.name);
        if (col.gameObject.name == "FPSController")
        {
            Debug.Log("Restart Level");
            Application.LoadLevel(Application.loadedLevel);
        }
    }

}
