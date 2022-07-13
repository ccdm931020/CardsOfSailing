using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class CardObject
{
    private CardProto cardProto;
    void startGameObject()
    {
        var obj = (GameObject) Resources.Load("Prefabs/CardProto");
        this.cardProto = obj.AddComponent<CardProto>();
        this.cardProto.cardObject = this;
        this.cardProto.start();
    }

    void stopGameObject()
    {
        this.cardProto.stop();
        GameObject.Destroy(this.cardProto.gameObject);
    }
}
