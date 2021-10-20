using UnityEngine;
using System.Collections;

public class MouseLock : MonoBehaviour
{
    public CursorLockMode wantedMode;
    public bool Locked;

    private void Start()
    {
        Locked = true;
    }

    // Apply requested cursor state
    void SetCursorState()
    {
        Locked = !Locked;
        if(Locked == true)
        {
            Cursor.lockState = wantedMode = CursorLockMode.None;
            Cursor.lockState = wantedMode = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = wantedMode = CursorLockMode.None;
            //Cursor.lockState = wantedMode = CursorLockMode.Confined;
            Cursor.visible = true;
        }
    }
   

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            SetCursorState();
        }
    }
}

 