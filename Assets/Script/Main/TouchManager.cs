using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchManager : MonoBehaviour
    
{
    public bool isTouched { get; set; }

    public void Start()
    {
        isTouched = false;
    }

    public void DownEvent()
    {
        isTouched = true;
    }
    public void UpEvent()
    {
        isTouched = false;
    }
}
