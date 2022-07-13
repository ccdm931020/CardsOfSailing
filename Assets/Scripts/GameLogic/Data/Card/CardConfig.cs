using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardType
{
    public const string None = "none";
    public const string Search = "search";
    public const string Move = "move";
    public const string Leader = "lead";
}

public class CardConfig : NSConfigObject
{
    public string name { get; private set; }
    public float cost { get; private set; }
    public float value { get; private set; }
    public string cardType { get; private set; }

    public override void initializeByParameters(Dictionary<string, object> parameters)
    {
        base.initializeByParameters(parameters);
        this.name = parameters.stringValue("name");
        this.cost = parameters.floatValue("cost");
        this.value = parameters.floatValue("value");
        this.cardType = parameters.stringValue("cardType", CardType.None);
    }
}