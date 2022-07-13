using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class BoatUnit : Unit
{
    protected override void popPrepare()
    {
        base.popPrepare();
        this.cardObjectList = new List<CardObject>();
    }

    protected override void popExtra()
    {
        base.popExtra();
        this.startCards();
    }

    protected override void pushExtra()
    {
        this.stopCards();
        base.pushExtra();
    }

    public override void update(float dt)
    {
        base.update(dt);
        this.updateCards(dt);
    }
}
