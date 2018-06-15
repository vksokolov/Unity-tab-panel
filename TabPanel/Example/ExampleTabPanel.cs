using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExampleTabPanel : TabPanel<ExampleTabPanelElement> {
    public Text Logger;
    protected override void OnClick(ExampleTabPanelElement element)
    {
        base.OnClick(element);
        string logString = element.name + ".ExampleField: " + element.ExampleField;
        Logger.text = logString;
        Debug.Log(logString);
    }
}
