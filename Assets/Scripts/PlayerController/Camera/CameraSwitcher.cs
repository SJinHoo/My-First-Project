using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraSwitcher : MonoBehaviour
{
    public CinemachineVirtualCamera Basiccam;
    public CinemachineVirtualCamera Turretcam;

    private void Update()
    {
        if (Keyboard.current.shiftKey.isPressed)
        {
            Basiccam.Priority = 0;  
            Turretcam.Priority = 1; 
        }
        else
        {
            Basiccam.Priority = 1;  
            Turretcam.Priority = 0; 
        }
    }
}
