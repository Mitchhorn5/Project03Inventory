using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class HandObject : MonoBehaviour
{
    public static event Action Item1Event;

    public void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Item1Event?.Invoke();
        }
    }
}
