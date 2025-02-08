using System;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent OnSpacePressed = new UnityEvent();
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpacePressed.Invoke();
        }
    }
}


