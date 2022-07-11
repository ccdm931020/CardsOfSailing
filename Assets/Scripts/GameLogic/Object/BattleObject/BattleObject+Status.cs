using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class BattleObject
{
    class BattleObjectStatus
    {
        public const int None = 0;
        public const int Prepare = 1;
        
        //行动阶段
        public const int ActionRound = 11;
        //结算结算
        public const int Calculate = 12;
        //事件触发
        public const int Event = 13;

        //靠岸的状态
        public const int Dock = 21;
        
    }
    protected override bool needStateObject => true;

    private float delay;
    private float currentDelay;
    
    void initStatus()
    {
        this.statusActions[BattleObjectStatus.Prepare] = this.runPrepare;
        this.updateActions[BattleObjectStatus.Prepare] = this.updatePrepare;

        this.statusActions[BattleObjectStatus.ActionRound] = this.runActionRound;

        this.statusActions[BattleObjectStatus.Calculate] = this.runCalculate;
        
        this.statusActions[BattleObjectStatus.Event] = this.runEvent;
        this.leaveActions[BattleObjectStatus.Event] = this.leaveEvent;

        this.statusActions[BattleObjectStatus.Dock] = this.runDock;
        this.leaveActions[BattleObjectStatus.Dock] = this.leaveDock;
    }

    void startStatus()
    {
        this.baseState = BattleObjectStatus.Prepare;
    }

    void stopStatus()
    {
    }

    void runPrepare()
    {
        //TODO：创建船
        
        this.delay = 1f;
        this.currentDelay = 0;
    }

    void updatePrepare(float dt)
    {
        this.currentDelay += dt;
        if (this.currentDelay > this.delay) {
            this.currentDelay = 0;
            this.baseState = BattleObjectStatus.ActionRound;
        }
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

    void runDock()
    {
        //TODO:靠岸
    }

    void leaveDock()
    {
    }
}
