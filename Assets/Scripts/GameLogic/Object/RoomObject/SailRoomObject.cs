using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SailRoomObject : RoomBaseObject
{
    class SailRoomObjectStatus
    {
        public const int None = 0;
        //行动阶段
        public const int ActionRound = 1;
        //结算结算
        public const int Calculate = 2;
        //事件触发
        public const int Event = 3;
    }
    
    private int maxStep;
    private int currentStep;

    protected override bool needStateObject => true;

    public override void init()
    {
        base.init();
        
        this.statusActions[SailRoomObjectStatus.ActionRound] = this.runActionRound;

        this.statusActions[SailRoomObjectStatus.Calculate] = this.runCalculate;
        
        this.statusActions[SailRoomObjectStatus.Event] = this.runEvent;
        this.leaveActions[SailRoomObjectStatus.Event] = this.leaveEvent;
    }
    
    void runActionRound()
    {
        //TODO:回合开始，抽卡
        
    }

    void runCalculate()
    {
        //TODO:结算，前进
    }

    void runEvent()
    {
        //TODO:事件出发
    }
    
    void leaveEvent()
    {
    }
}
