using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public abstract class TabPanelElement : MonoBehaviour
{
    protected Button Button;
    protected void Awake()
    {
        Button = GetComponent<Button>();
    }
    public virtual void SetupOnClick(Action<TabPanelElement> action)
    {
        Button.onClick.AddListener(delegate ()
        {
            action.Invoke(this);
        });
    }
}
