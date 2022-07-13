using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class CardObject : BaseObject
{
    public CardInsData cardInsData;

    public override void start()
    {
        base.start();
        this.startGameObject();
        this.startAction();
    }

    public override void stop()
    {
        this.stopAction();
        this.stopGameObject();
        base.stop();
    }
}
