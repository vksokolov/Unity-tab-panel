using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabPanel<T> : MonoBehaviour where T : TabPanelElement
{
    public List<T> Tabs;
    protected virtual void Start()
    {
        
        foreach (T element in Tabs)
        {
            element.SetupOnClick((T) => OnClick(element));
        }
    }
    protected virtual void OnClick(T element)
    { 
        Debug.Log("Name: " + element.name);
    }
}
