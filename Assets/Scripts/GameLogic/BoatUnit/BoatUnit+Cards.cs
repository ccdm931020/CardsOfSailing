using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class BoatUnit
{
    private List<CardObject> cardObjectList;

    void startCards()
    {
    }

    void updateCards(float dt)
    {
        foreach (var o in this.cardObjectList) {
            if (o.isOver) {
                o.stop();
            }
            else {
                o.update(dt);
            }
        }

        this.cardObjectList.RemoveAll(x => x.isOver);
    }

    void stopCards()
    {
    }

    public void addCardObject(CardInsData cardInsData)
    {
        var obj = DataUtils.Instance.getActivator<CardObject>("CardObject");
        obj.cardInsData = cardInsData;
        obj.start();
        this.cardObjectList.Add(obj);
    }
}
