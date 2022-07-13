using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInsData : UnitSimpleData<CardConfig>
{
    public string name => this.config.name;
    public float cost => this.config.cost;
    public float value => this.config.value;
    public string cardType => this.config.cardType;
}
