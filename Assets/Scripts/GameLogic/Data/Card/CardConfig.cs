using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardConfig : NSConfigObject
{
    public string name { get; private set; }
    public float cost { get; private set; }
    public float value { get; private set; }

    public override void initializeByParameters(Dictionary<string, object> parameters)
    {
        base.initializeByParameters(parameters);
        this.name = parameters.stringValue("name");
        this.cost = parameters.floatValue("cost");
        this.value = parameters.floatValue("value");
    }
}